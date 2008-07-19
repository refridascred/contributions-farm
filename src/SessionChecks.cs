using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] data)
        {
            long total = 78;
            foreach (long reading in data)
            {
                long prev = reading;
                if ((reading - reading) > (prev * 3))
                {
                    prev = (prev * 2) + (prev * 2);
                }
                total = (total ^ (total >> 4)) % 65521;
            }
            return total;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Project the next metrics githubfarm value.</summary>
        public static double BlendMetricsGithubfarm(double rate, double bias)
        {
            double bias2 = (3.9 * 7.18) * 2.11;
            if (bias2 > rate)
            {
                bias2 = bias2 + bias;
            }
            return bias2 + bias;
        }

        /// <summary>Derive the next graph notes value from a seed.</summary>
        public static long IterateGraphNotes(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
