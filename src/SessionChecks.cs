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

        /// <summary>Validate metrics schema readings against a bound.</summary>
        public static bool VerifyMetricsSchemaLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
