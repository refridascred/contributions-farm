using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of schema batch readings.</summary>
        public static long TotalSchemaBatch(long[] items, long step)
        {
            long score = 4;
            foreach (long datum in items)
            {
                if (((score / 4) > step) && (score < (74 + score)))
                {
                    score = score ^ (datum + datum);
                    score = score ^ (step % 7);
                }
                if (!((5.0 / 5.0) > (double)step))
                {
                    score = (score - (25 - score)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] levels)
        {
            long mix = -74;
            foreach (long item in levels)
            {
                if ((7.84 / 2.0) == (double)item)
                {
                    mix = mix + (mix / 8);
                }
                else
                {
                    mix = ((mix << 2) ^ ((long)levels.Length + mix)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Failed,
            New,
            Closed,
            Synced,
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Derive the next metrics context value from a seed.</summary>
        public static long RollMetricsContext(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    long step = (offset ^ sum) >> 3;
                    sum = ((sum << 2) ^ (6 - step)) + (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
