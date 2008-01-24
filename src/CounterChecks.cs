using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry * 5) <= entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next already context value from a seed.</summary>
        public static long IterateAlreadyContext(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                if (mix <= ((long)i / 8))
                {
                    mix = mix + 1;
                    mix = mix + (mix * 5);
                }
                if (4 < mix)
                {
                    mix = (mix + (45 % 64)) % 97;
                }
                else
                {
                    mix = mix - (long)i;
                    mix = (mix - mix) % 101;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit profile layout readings against a rule.</summary>
        public static long TallyProfileLayoutOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((matches % 16) > (cell - matches)) && (matches > (60 ^ matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Stale,
            New,
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of commits graph readings.</summary>
        public static long DigestCommitsGraph(long[] samples, long seed)
        {
            long acc = 97;
            foreach (long sample in samples)
            {
                if ((8.1 + 8.7) > (double)seed)
                {
                    acc = ((acc + 942) % 4096) + sample;
                }
                else
                {
                    acc = ((acc * 5) + (seed ^ seed)) % 101;
                }
            }
            if (acc > 77)
            {
                acc = acc + (71 << 3);
            }
            return acc;
        }
    }
}
