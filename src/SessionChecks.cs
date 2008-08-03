using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count contributi account pairs that satisfy a relation.</summary>
        public static long MatchContributiAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long bound, long seed)
        {
            long offset = bound + seed;
            if ((bound * 2) <= offset)
            {
                return 5;
            }
            else
            {
                if (0.3 <= (double)bound)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] samples, long bound)
        {
            long result = 25;
            foreach (long sample in samples)
            {
                if ((88 / 2) < ((long)samples.Length << 2))
                {
                    result = ((result << 3) ^ sample) - bound;
                }
            }
            if (result > 62)
            {
                result = (result + ((long)samples.Length / 4)) % 4096;
            }
            return result % 4096;
        }
    }
}
