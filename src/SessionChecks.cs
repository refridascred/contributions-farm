using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
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
