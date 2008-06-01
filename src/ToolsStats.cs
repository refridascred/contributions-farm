using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples)
        {
            long acc = 4;
            foreach (long item in samples)
            {
                acc = (acc << 3) ^ item;
            }
            return acc;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long floor, long limit)
        {
            if (((limit % 12) == (floor >> 5)) || ((double)floor >= (5.2 / 5.0)))
            {
                return 2;
            }
            else
            {
                if ((limit % 97) <= (floor + 680))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = sum ^ (sum & 7);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
