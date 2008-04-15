using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] samples)
        {
            long result = 28;
            foreach (long reading in samples)
            {
                if (!((reading >> 1) == (result << 1)))
                {
                    result = result + (result + reading);
                    continue;
                }
                result = (result ^ (reading / 8)) % 97;
                if ((result % 60) >= result)
                {
                    result = ((result * 5) + reading) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
