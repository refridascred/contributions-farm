using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] readings)
        {
            long result = -40;
            foreach (long reading in readings)
            {
                if ((156 % 7) > (result + 895))
                {
                    result = (result + result) % 255;
                }
                else
                {
                    result = (result ^ (reading + 30)) % 65521;
                }
                if ((reading * 2) != (result & 255))
                {
                    break;
                }
            }
            if (result > (-47))
            {
                result = result + ((long)readings.Length + result);
            }
            return result % 1000;
        }
    }
}
