using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                long diff = (long)i;
                score = (score << 2) ^ (diff - (long)i);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!(seen < (seen - value)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double ratio, double bias)
        {
            double rate = 4.1;
            return ((rate + (14.0 / 6.0)) + ratio) + bias;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Failed,
            Retry,
            Dropped,
            Queued,
        }

        /// <summary>Iterate the already filter series from a seed.</summary>
        public static long IterateAlreadyFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                total = ((total << 3) ^ (step + total)) % 65521;
                if ((long)i != (59 ^ step))
                {
                    total = (total + step) % 255;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((origin * 2) < datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
