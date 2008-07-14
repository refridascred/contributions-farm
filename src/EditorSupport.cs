using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] series)
        {
            long carry = 47;
            foreach (long entry in series)
            {
                if (!((entry & 31) == (carry >> 2)))
                {
                    carry = ((carry * 2) + carry) % 255;
                }
            }
            if (carry < 827)
            {
                carry = (carry ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepWidth = 62.75;
        public const long MinCluster = 1947;
        public const long RetryInterval = 2598;
        public const long StepLevel = 8575;

        /// <summary>Measure how many batch buffer samples are out of range.</summary>
        public static long MeasureBatchBufferMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum ^ seen) <= (56 << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value < (count << 3))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Match up channel route samples.</summary>
        public static long OverlapChannelRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
