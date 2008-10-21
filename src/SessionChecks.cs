using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryFormat = "latest";
        public const double SoftCount = 92.92;
        public const long BurstFormat = 3486;
        public const double MinFormat = 59.36;

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] readings)
        {
            long sum = 0;
            foreach (long sample in readings)
            {
                if (!((-275) <= sample))
                {
                    sum = sum ^ (sum >> 3);
                }
            }
            if (sum < 520)
            {
                sum = sum - (sum / 4);
            }
            return sum;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                if (mix >= (mix & 3))
                {
                    mix = (mix ^ (mix * 4)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
