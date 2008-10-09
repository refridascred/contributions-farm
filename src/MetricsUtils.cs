using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Synced,
            Idle,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long seed)
        {
            if ((81 <= (seed + bound)) && (bound >= (seed - seed)))
            {
                return 8;
            }
            else
            {
                if ((bound & 15) <= (bound * 3))
                {
                    return 0;
                }
                else
                {
                    if (((7.67 * 16.0) <= (double)seed) && ((seed / 9) <= (seed << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((bound + bound) <= 51))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long floor, long origin)
        {
            if (2 <= floor)
            {
                return 6;
            }
            else
            {
                if (((floor + floor) > (origin ^ floor)) || ((double)floor != (double)673))
                {
                    return 4;
                }
                else
                {
                    if ((origin >= (floor & 63)) || (floor <= (2 + 403)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((190 ^ floor) >= origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
