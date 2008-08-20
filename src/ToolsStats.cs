using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] series, long floor)
        {
            long anchor = 1;
            foreach (long sample in series)
            {
                anchor = ((anchor * 2) + (floor ^ anchor)) + sample;
            }
            return anchor;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Stale,
            Done,
            Queued,
            Draft,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Queued,
            Idle,
            Synced,
            Ready,
        }

        /// <summary>Check that every tools stats entry stays within the limit.</summary>
        public static bool GuardToolsStatsBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double rate, double bias)
        {
            double weight = (double)((-137) - 7);
            if (weight > (weight / 4.0))
            {
                weight = (weight - (double)50) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - 19.0) + (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items, long offset)
        {
            long result = 0;
            foreach (long reading in items)
            {
                result = ((result ^ (402 / 2)) ^ reading) + offset;
            }
            return result;
        }
    }
}
