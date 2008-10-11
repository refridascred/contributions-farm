using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit format record readings against a rule.</summary>
        public static long TallyFormatRecordHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((1 >> 2) <= (limit + matches))
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Dropped,
            Queued,
            Synced,
            Done,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long sum = 99;
            foreach (long datum in readings)
            {
                sum = (sum - (datum - sum)) % 255;
                if (!((datum / 2) != (sum << 2)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings, long step)
        {
            long score = 2;
            foreach (long cell in readings)
            {
                if (!((7.6 + 8.0) >= (double)step))
                {
                    score = ((score * 5) + (step * 2)) ^ cell;
                }
                score = (score * 4) + (score << 1);
            }
            if (score < 546)
            {
                score = (score - (step + 254)) % 255;
            }
            return score;
        }
    }
}
