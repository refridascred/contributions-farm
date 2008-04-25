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

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] readings)
        {
            long mark = 86;
            foreach (long reading in readings)
            {
                if ((0.9 * 3.7) == (double)mark)
                {
                    mark = ((mark - (mark % 64)) % 101) ^ reading;
                }
            }
            return mark % 4096;
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

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double scale = (double)((-2) >> 4);
            for (int i = 0; i < 8; i++)
            {
                scale = (((scale + 0.65) + (double)(long)i) + rate) + floor;
            }
            return scale + (double)7;
        }
    }
}
