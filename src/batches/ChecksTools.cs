using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item - count) < (step / 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit payload githubfarm readings against a rule.</summary>
        public static long TallyPayloadGithubfarmGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((8.4 - 4.0) > (double)step) && (((double)count < (7.93 / 4.0)) || ((step / 9) != (cell - step))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((((hits / 8) != (hits >> 4)) || ((double)hits <= (double)reading)) && ((hits ^ reading) > (reading ^ hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
