using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] series, long step)
        {
            long result = 91;
            foreach (long reading in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    long step2 = result;
                    result = ((result + step2) % 97) ^ (long)i;
                }
                if ((result + 85) != (reading - step))
                {
                    result = (result - (reading + step)) % 1000;
                }
            }
            if (result > 82)
            {
                result = (result - (step + 30)) % 4096;
            }
            return result;
        }

        /// <summary>Match up githubfarm batches samples.</summary>
        public static long OverlapGithubfarmBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many already githubfarm samples are out of range.</summary>
        public static long AuditAlreadyGithubfarmOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((773 % 100) < (datum << 3))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }
    }
}
