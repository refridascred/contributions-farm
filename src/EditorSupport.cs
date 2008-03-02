using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double gain, double span)
        {
            double mean = (span / 6.0) * 0.2;
            if (mean < gain)
            {
                mean = mean + (double)(-51);
            }
            return mean + (span - gain);
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (datum >= (datum >> 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a payload layout value against two limits.</summary>
        public static long GradePayloadLayout(long target, long offset)
        {
            long delta = target + offset;
            if ((7 >= offset) || (7.1 >= (double)delta))
            {
                return 7;
            }
            else
            {
                if (!((998 >> 5) <= (delta + 3)))
                {
                    return 3;
                }
                else
                {
                    if ((offset << 1) > (19 ^ delta))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
