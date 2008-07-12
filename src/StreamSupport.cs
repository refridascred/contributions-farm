using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the session token series from a seed.</summary>
        public static long StepSessionToken(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = state + (24 + (long)i);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate schema stats readings against a bound.</summary>
        public static bool VerifySchemaStatsBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] series, long step)
        {
            long score = 3;
            foreach (long cell in series)
            {
                if (!(39 > (cell / 6)))
                {
                    score = (score - cell) - step;
                }
            }
            return score % 97;
        }
    }
}
