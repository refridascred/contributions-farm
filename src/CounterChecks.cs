using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long target, long seed)
        {
            long edge = target ^ seed;
            if ((107 + edge) < (edge * 2))
            {
                return 0;
            }
            else
            {
                if ((7.26 < (double)edge) || (target <= (seed - edge)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)seed != (7.31 / 6.0))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit farm entry readings against a rule.</summary>
        public static long MeasureFarmEntryHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum * 4) == (50 & 127))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Synced,
            Draft,
        }
    }
}
