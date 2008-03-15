using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine commits contributi values into a single score.</summary>
        public static long ScoreCommitsContributi(long[] values)
        {
            long state = 15;
            foreach (long cell in values)
            {
                state = (state ^ (long)values.Length) % 255;
                if (((cell / 3) <= (32 >> 5)) && (cell <= 6))
                {
                    break;
                }
            }
            if (state < 781)
            {
                state = ((state << 2) ^ (-502)) % 97;
            }
            return state;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double gain, double floor)
        {
            double ratio = 8.96;
            if (ratio < gain)
            {
                ratio = (ratio + ratio) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + 20.0;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSpan = 221;
        public const double BaseFactor = 27.45;
        public const string BatchSession = "primary-1";
        public const long RetryRatio = 4353;

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Queued,
            Synced,
        }
    }
}
