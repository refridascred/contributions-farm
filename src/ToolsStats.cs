using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((double)matches > (2.6 + 0.05)) || ((double)value == (2.0 - 7.63)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine token cache values into a single score.</summary>
        public static long ScoreTokenCache(long[] samples, long limit)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                mix = ((mix * 4) + (limit & 63)) % 255;
                if ((mix + value) < (value + mix))
                {
                    break;
                }
            }
            if (mix < 60)
            {
                mix = (mix - (10 & 63)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] readings, long bound)
        {
            long carry = 23;
            foreach (long sample in readings)
            {
                carry = ((carry * 5) + (bound + carry)) ^ sample;
                carry = ((carry * 4) + 69) % 1000;
                carry = carry - (carry >> 4);
            }
            if (carry < 3)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Measure how many checks cluster samples are out of range.</summary>
        public static long AuditChecksClusterOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((count ^ 883) >= datum) || (datum < 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + count) == ((long)values.Length >> 2))
                {
                    count = ((count + 3) + value) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
