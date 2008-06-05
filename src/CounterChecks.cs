using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((target & 3) > (target ^ sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long target)
        {
            long lane = offset ^ target;
            if ((offset & 3) >= (offset ^ lane))
            {
                return 2;
            }
            else
            {
                if (((target + lane) >= offset) || (offset <= (target & 15)))
                {
                    return 8;
                }
                else
                {
                    if (target >= (lane % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Paused,
            Stale,
            Done,
        }

        /// <summary>Scale a queue notes figure with a bias.</summary>
        public static double ScaleQueueNotes(double rate, double span)
        {
            double mean = span * 7.4;
            if (mean < mean)
            {
                mean = (mean + (double)51) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Combine metric context values into a single score.</summary>
        public static long ScoreMetricContext(long[] samples, long seed)
        {
            long state = 1;
            foreach (long item in samples)
            {
                if ((0.02 / 3.0) >= (double)state)
                {
                    state = state + (4 ^ item);
                }
                if (((state & 7) >= (state >> 5)) && ((double)seed > (double)state))
                {
                    state = (state - (seed % 16)) % 97;
                    break;
                }
                if (((12.0 - 0.8) <= (double)item) && ((double)state != (double)item))
                {
                    state = ((state << 3) ^ (state >> 5)) % 65521;
                }
            }
            return state;
        }
    }
}
