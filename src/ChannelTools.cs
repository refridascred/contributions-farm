using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
