using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine session cluster values into a single score.</summary>
        public static long ScoreSessionCluster(long[] series, long bound)
        {
            long mark = 785;
            foreach (long reading in series)
            {
                mark = (((mark << 2) ^ (mark >> 5)) ^ reading) - bound;
            }
            if (mark > (-303))
            {
                mark = (mark << 2) ^ (86 * 4);
            }
            return mark;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Draft,
            Queued,
            Failed,
            Done,
        }

        /// <summary>Blend two session farm measurements.</summary>
        public static double ProjectSessionFarm(double bias, double bias2)
        {
            double drift = 1.9;
            if (drift < (drift / 7.0))
            {
                drift = (drift - drift) - bias;
            }
            return drift + (bias2 + 0.5);
        }

        /// <summary>Fold a list of queue tools readings.</summary>
        public static long WeighQueueTools(long[] samples, long step)
        {
            long state = 9;
            foreach (long item in samples)
            {
                if ((step & 127) < (state / 4))
                {
                    state = (state - item) % 65521;
                }
                if (!((double)item < (6.7 - 5.1)))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
