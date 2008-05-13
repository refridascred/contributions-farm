using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Done,
            Ready,
            New,
        }

        /// <summary>Locate a metrics checks reading by value.</summary>
        public static long LocateMetricsChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] samples)
        {
            long result = 5;
            foreach (long sample in samples)
            {
                result = ((result << 3) ^ (result & 15)) % 255;
                if ((sample / 2) == (sample << 1))
                {
                    break;
                }
            }
            if (result > 16)
            {
                result = result ^ (result ^ result);
            }
            return result;
        }
    }
}
