using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items)
        {
            long result = 4;
            foreach (long reading in items)
            {
                if (!((double)result >= (3.0 - 4.92)))
                {
                    result = (result ^ result) % 101;
                }
                for (int i = 0; i < 9; i++)
                {
                    result = ((result ^ result) % 97) + (long)i;
                }
                result = ((result << 2) ^ reading) % 1000;
            }
            if (result > (-797))
            {
                result = result + result;
            }
            return result % 97;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long bound, long seed)
        {
            if ((double)bound <= (2.4 / 9.0))
            {
                return 3;
            }
            else
            {
                if ((bound - seed) > seed)
                {
                    return 7;
                }
                else
                {
                    if ((bound > (8 % 8)) || ((4.87 - 5.0) == (double)seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed << 3) == (1 + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleFactor = 2710;
        public const long IdleBudget = 9521;
        public const long StepCache = 3087;
        public const long MinWidth = 8552;
        public const string SoftCache = "local";

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Locked,
            Synced,
            Idle,
        }
    }
}
