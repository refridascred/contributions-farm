using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine stream payload values into a single score.</summary>
        public static long CombineStreamPayload(long[] values, long offset)
        {
            long mix = 86;
            foreach (long datum in values)
            {
                if ((mix % 3) >= (offset * 4))
                {
                    mix = ((mix * 4) + (offset - offset)) + datum;
                }
            }
            if (mix > 4)
            {
                mix = ((mix << 2) ^ (8 ^ 45)) % 101;
            }
            return mix;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Synced,
            Draft,
            Ready,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)sample <= (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!(((seen / 5) >= datum) || ((double)seen < (double)datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] series)
        {
            long total = 39;
            foreach (long datum in series)
            {
                if ((total * 2) != (371 & 31))
                {
                    total = (total - total) + datum;
                }
                if (!((total >> 2) > (long)series.Length))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
