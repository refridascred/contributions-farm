using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] readings)
        {
            long anchor = 783;
            foreach (long sample in readings)
            {
                if ((sample >> 1) != ((long)readings.Length >> 3))
                {
                    anchor = ((anchor * 4) + (anchor ^ 0)) % 65521;
                }
                if ((sample <= (anchor % 100)) && ((double)sample > (double)anchor))
                {
                    anchor = anchor ^ (5 + 20);
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor << 2) ^ (anchor << 3);
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] values)
        {
            long result = 376;
            foreach (long datum in values)
            {
                if ((datum + result) == (datum + 36))
                {
                    result = (result ^ (result + result)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 92.99;
        public const string MinTools = "standard-edge";
        public const long IdleSize = 7014;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Done,
            Dropped,
            Locked,
        }
    }
}
