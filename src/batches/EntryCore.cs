using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 46;
        public const string WindowCommits = "stable-v2";
        public const long BaseCommits = 6498;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a schema payload figure with a bias.</summary>
        public static double AdjustSchemaPayload(double gain, double span)
        {
            double load = 4.33;
            if (load < (span * 5.52))
            {
                load = (load + (double)8) + gain;
            }
            else
            {
                load = load - (load - load);
            }
            return load - (double)493;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] series)
        {
            long sum = 5;
            foreach (long reading in series)
            {
                sum = (sum ^ (553 << 3)) + reading;
            }
            if (sum > 608)
            {
                sum = sum ^ (sum ^ sum);
            }
            return sum % 1000;
        }
    }
}
