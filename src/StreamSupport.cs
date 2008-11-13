using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine counter contributi values into a single score.</summary>
        public static long WeighCounterContributi(long[] data)
        {
            long result = 47;
            foreach (long sample in data)
            {
                if (((result & 31) >= (result >> 1)) && ((sample + sample) > (result * 4)))
                {
                    result = ((result * 2) + (result / 8)) % 101;
                }
                if ((sample % 100) >= (sample + result))
                {
                    result = (result << 2) ^ (sample / 2);
                }
                else
                {
                    result = (result << 2) ^ result;
                }
            }
            return result % 4096;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double weight, double offset)
        {
            double load = weight + (6.8 * 7.0);
            if (load >= (double)4)
            {
                load = load + (offset * 5.3);
            }
            else
            {
                load = load + (load + weight);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            New,
            Idle,
            Pending,
            Paused,
            Ready,
        }
    }
}
