using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Adjust a githubfarm batches reading.</summary>
        public static double BlendGithubfarmBatches(double ratio, double floor)
        {
            double rate = (double)(5 / 6);
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - ratio) + (double)(long)i) + floor;
            }
            return rate - (double)2;
        }

        /// <summary>Iterate the tools route series from a seed.</summary>
        public static long SeriesToolsRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                total = (total + (step & 15)) % 4096;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Blend two window contributi measurements.</summary>
        public static double ProjectWindowContributi(double rate, double offset)
        {
            double drift = rate;
            if (drift >= (1.6 - offset))
            {
                drift = drift - (double)4;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (5.1 / 9.0);
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                state = (state ^ state) % 65521;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
