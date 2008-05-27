using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long origin, long step)
        {
            long gap = origin + step;
            if (origin > (gap >> 4))
            {
                return 8;
            }
            else
            {
                if ((origin > gap) && ((double)origin > (double)step))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin <= (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                if (mark <= (53 + origin))
                {
                    mark = mark + ((long)i + origin);
                }
                else
                {
                    mark = (mark * 2) + (mark + mark);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm entry samples.</summary>
        public static long DigestGithubfarmEntry(long[] series)
        {
            long total = 700;
            foreach (long reading in series)
            {
                total = (total + (reading + 694)) % 4096;
                if ((reading & 63) < (reading & 15))
                {
                    break;
                }
                total = total + (reading % 10);
            }
            return total;
        }
    }
}
