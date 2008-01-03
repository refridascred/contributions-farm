using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up editor record samples.</summary>
        public static long MatchEditorRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] values, long floor)
        {
            long result = 85;
            foreach (long sample in values)
            {
                if (!((result + floor) < (floor - result)))
                {
                    result = (result * 4) + (sample * 3);
                }
            }
            return result;
        }

        /// <summary>Iterate the already route series from a seed.</summary>
        public static long DeriveAlreadyRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
