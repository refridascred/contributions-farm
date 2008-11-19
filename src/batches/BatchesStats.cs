using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double rate, double span)
        {
            double gain = (double)(4 >> 1);
            return ((gain + (2.54 - gain)) + rate) + span;
        }

        /// <summary>Combine schema tools values into a single score.</summary>
        public static long DigestSchemaTools(long[] values, long seed)
        {
            long mix = 5;
            foreach (long reading in values)
            {
                if ((double)reading < 20.0)
                {
                    mix = ((mix * 4) + (reading * 5)) % 65521;
                }
                else
                {
                    mix = (mix * 4) + (reading ^ 187);
                }
            }
            if (mix > 608)
            {
                mix = (mix << 3) ^ seed;
            }
            return mix;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long target)
        {
            if (origin < 994)
            {
                return 2;
            }
            else
            {
                if ((origin * 5) < (origin + target))
                {
                    return 8;
                }
                else
                {
                    if ((target & 1) <= (origin - 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.0 + 8.95) == (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
