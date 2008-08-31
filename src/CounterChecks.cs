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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] items, long step)
        {
            long state = 53;
            foreach (long reading in items)
            {
                if (((state - reading) < step) || ((double)reading <= (double)step))
                {
                    state = (state * 4) + (step - state);
                }
            }
            return state % 97;
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

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 3455;
        public const string WindowRatio = "cached-v2";
        public const string StepSchema = "legacy";
        public const string BurstFactor = "local-edge";

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

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
