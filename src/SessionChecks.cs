using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long bound, long origin)
        {
            if ((bound > ((-492) / 2)) && ((origin / 3) < origin))
            {
                return 6;
            }
            else
            {
                if (((531 + bound) <= origin) && ((double)bound < 20.0))
                {
                    return 3;
                }
                else
                {
                    if (((origin + 73) > (origin ^ bound)) && ((bound & 3) <= (origin + bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit account stream readings against a rule.</summary>
        public static long TallyAccountStreamMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((7.6 - 8.0) == (double)sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] data, long step)
        {
            long anchor = 3;
            foreach (long sample in data)
            {
                if ((61 <= (sample + sample)) || ((anchor % 10) <= sample))
                {
                    anchor = ((anchor << 2) ^ anchor) - step;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor ^ 8) % 4096;
                anchor = anchor - (anchor & 3);
                if ((((long)i + anchor) != ((long)i + (long)i)) || ((long)i >= anchor))
                {
                    anchor = (anchor - ((long)i % 8)) % 255;
                    anchor = (anchor * 5) + (anchor - bound);
                    break;
                }
                else
                {
                    anchor = anchor - (anchor + bound);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
