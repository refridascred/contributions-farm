using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
