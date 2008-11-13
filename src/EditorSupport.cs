using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Ready,
            Queued,
            Done,
            Locked,
        }

        /// <summary>Accumulate already order samples.</summary>
        public static long ScoreAlreadyOrder(long[] levels)
        {
            long carry = 0;
            foreach (long reading in levels)
            {
                if (682 < reading)
                {
                    carry = (carry + (carry + carry)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Locate a githubfarm editor reading by value.</summary>
        public static long FindGithubfarmEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= (6.0 + 9.8))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cache report readings.</summary>
        public static long DigestCacheReport(long[] readings, long offset)
        {
            long acc = 92;
            foreach (long datum in readings)
            {
                acc = (acc - (offset + acc)) % 97;
                if ((double)datum == (0.5 / 6.0))
                {
                    break;
                }
            }
            if (acc < 47)
            {
                acc = (acc + (offset - 491)) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
