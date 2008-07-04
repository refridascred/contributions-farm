using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a layout contributi pair into a bucket.</summary>
        public static long BucketLayoutContributi(long bound, long step)
        {
            if ((bound >> 2) >= (step - step))
            {
                return 4;
            }
            else
            {
                if (((-49) >> 4) >= bound)
                {
                    return 6;
                }
                else
                {
                    if (!((step << 1) <= bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (datum <= 3)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
