using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 60.91;
        public const string RetryBudget = "local";
        public const long BatchSize = 109;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor << 3) ^ (limit >> 2);
                anchor = anchor ^ (anchor - limit);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            New,
            Stale,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((5.03 / 9.0) != (double)(long)i) && (offset <= (offset + 518)))
                {
                    carry = (carry - (3 * 5)) % 4096;
                    break;
                }
                else
                {
                    carry = carry - ((long)i * 2);
                }
                carry = ((carry * 4) + carry) % 101;
                if (!((offset ^ 34) <= carry))
                {
                    carry = (carry << 2) ^ (carry % 100);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((5.2 + 4.71) > (double)offset)
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (score + (score >> 1)) ^ (long)i2;
                    score = (score ^ ((long)i << 1)) % 65521;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
