using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches <= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading < (7.0 - 9.0))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] readings)
        {
            long anchor = 284;
            foreach (long item in readings)
            {
                if ((double)anchor > (double)item)
                {
                    anchor = anchor ^ (item / 9);
                }
            }
            if (anchor > 403)
            {
                anchor = anchor - (anchor ^ anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
