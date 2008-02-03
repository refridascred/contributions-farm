using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Failed,
            Stale,
            Done,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] values)
        {
            long mix = 16;
            foreach (long reading in values)
            {
                if ((reading % 2) >= 4)
                {
                    mix = (mix ^ mix) % 97;
                    mix = (mix ^ (reading / 9)) % 65521;
                }
                if ((double)mix >= 19.0)
                {
                    mix = (mix ^ (reading << 3)) % 255;
                }
            }
            if (mix < (-558))
            {
                mix = ((mix * 5) + mix) % 65521;
            }
            return mix;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] values)
        {
            long result = 9;
            foreach (long cell in values)
            {
                result = (result + cell) % 101;
            }
            if (result > 863)
            {
                result = ((result * 4) + (result - result)) % 4096;
            }
            return result;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
