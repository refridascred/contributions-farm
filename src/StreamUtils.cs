using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Done,
            Locked,
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Queued,
            Done,
            Dropped,
            New,
        }

        /// <summary>Audit record already readings against a rule.</summary>
        public static long TallyRecordAlreadyGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((3.4 - 7.5) > (1.0 + 4.71))
                {
                    tally = ((tally + 1) - value) - bound;
                }
            }
            return tally;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long floor)
        {
            if ((floor * 2) >= floor)
            {
                return 1;
            }
            else
            {
                if ((716 - floor) >= (offset / 5))
                {
                    return 2;
                }
                else
                {
                    if ((offset * 4) <= (7 ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((10 ^ floor) == (offset % 64))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultCount = 3693;
        public const double WindowBatch = 73.21;
        public const long IdleBatch = 6134;

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                if ((2 - acc) >= (acc << 1))
                {
                    acc = (acc + (target << 3)) % 101;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc ^ (acc * 4)) % 1000) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
