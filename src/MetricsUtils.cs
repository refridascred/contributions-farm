using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "open-1";
        public const long BaseContext = 1143;
        public const long MaxCount = 4942;
        public const string WindowContext = "standard-edge";

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of schema profile readings.</summary>
        public static long ScoreSchemaProfile(long[] series, long bound)
        {
            long result = 1;
            foreach (long reading in series)
            {
                if ((bound + 4) < (result * 4))
                {
                    result = result + (result * 5);
                }
                else
                {
                    result = (result * 2) + reading;
                }
            }
            if (result > 881)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long score = 489;
            foreach (long value in readings)
            {
                if (9 <= score)
                {
                    score = ((score * 3) + (value & 1)) % 255;
                }
            }
            if (score < 1)
            {
                score = ((score << 3) ^ (score & 127)) % 101;
            }
            return score;
        }
    }
}
