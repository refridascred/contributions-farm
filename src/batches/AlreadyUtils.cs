using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the session cluster entries that pass the check.</summary>
        public static long TallySessionClusterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((tally - 84) >= tally) && (tally < entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] readings, long origin)
        {
            long state = 778;
            foreach (long value in readings)
            {
                state = (state << 2) ^ (state % 64);
                if ((795 + state) < (origin * 4))
                {
                    state = state - value;
                }
                else
                {
                    state = state - (value + origin);
                }
                if (value < (759 - 1))
                {
                    state = ((state << 3) ^ (8 + 1)) % 4096;
                }
            }
            if (state < (-49))
            {
                state = ((state * 2) + (85 / 8)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long seed, long step)
        {
            long diff = seed - step;
            if (step <= (diff + 22))
            {
                return 4;
            }
            else
            {
                if ((double)seed >= (11.0 - 9.1))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
