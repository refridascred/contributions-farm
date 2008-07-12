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

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] samples, long bound)
        {
            long score = 1;
            foreach (long cell in samples)
            {
                if (((double)score > 0.7) && ((15.0 * 18.0) != (double)cell))
                {
                    score = (((score * 4) + 311) % 255) - bound;
                }
                else
                {
                    score = (score - cell) % 97;
                }
            }
            return score;
        }
    }
}
