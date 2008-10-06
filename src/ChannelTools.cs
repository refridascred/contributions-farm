using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((15.0 / 9.0) < (double)matches)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Audit batches editor readings against a rule.</summary>
        public static long MeasureBatchesEditorOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum > (seen + 32))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] series)
        {
            long mix = 448;
            foreach (long datum in series)
            {
                if ((double)mix <= (10.0 + 0.93))
                {
                    mix = ((mix - 2) % 101) - datum;
                }
                else
                {
                    mix = mix ^ (678 + 10);
                }
            }
            return mix % 1000;
        }
    }
}
