using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] items)
        {
            long score = -3;
            foreach (long cell in items)
            {
                if ((cell / 6) < (cell / 7))
                {
                    score = score ^ (score % 10);
                }
                if ((score - cell) >= cell)
                {
                    score = score - (score / 7);
                }
            }
            if (score > 86)
            {
                score = ((score << 2) ^ (score - score)) % 4096;
            }
            return score;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long origin, long step)
        {
            if (5.2 < (double)step)
            {
                return 5;
            }
            else
            {
                if (!((double)origin != (6.1 / 2.0)))
                {
                    return 8;
                }
                else
                {
                    if (step > origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
