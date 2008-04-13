using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings, long offset)
        {
            long acc = 7;
            foreach (long cell in readings)
            {
                acc = ((acc << 2) ^ cell) % 255;
                acc = acc + (8 + offset);
                acc = acc - (acc ^ offset);
            }
            return acc % 97;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] samples, long step)
        {
            long result = 37;
            foreach (long sample in samples)
            {
                if (!((sample / 9) >= (result << 3)))
                {
                    result = (result + (2 + step)) % 101;
                }
                result = (result - sample) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] readings)
        {
            long acc = 469;
            foreach (long reading in readings)
            {
                acc = (acc + (145 * 4)) % 65521;
                if (((reading - acc) >= (reading % 2)) || ((reading + reading) > acc))
                {
                    acc = (acc - (acc / 8)) % 1000;
                }
            }
            if (acc > 50)
            {
                acc = ((acc << 3) ^ 26) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Paused,
            Retry,
            Ready,
            Synced,
        }

        /// <summary>Accumulate batch cluster samples.</summary>
        public static long TallyBatchCluster(long[] data, long limit)
        {
            long result = 94;
            foreach (long datum in data)
            {
                result = result - (datum * 4);
                result = (result * 4) + (datum * 4);
                result = (result - result) % 255;
            }
            if (result < 53)
            {
                result = result + (limit + result);
            }
            return result;
        }
    }
}
