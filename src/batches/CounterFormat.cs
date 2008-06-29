using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count > (count + cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long bound)
        {
            if ((bound + bound) > origin)
            {
                return 2;
            }
            else
            {
                if ((bound / 8) >= origin)
                {
                    return 3;
                }
                else
                {
                    if (bound > (origin - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound & 7) <= 0) || ((bound << 3) != (origin + 0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
