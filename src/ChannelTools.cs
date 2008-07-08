using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double scale, double offset)
        {
            double load = (9.71 + 18.0) - (scale + 2.0);
            if (load > offset)
            {
                load = load + (load - scale);
            }
            return load + scale;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Done,
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen > 18)
                {
                    seen = ((seen + 2) + cell) + step;
                }
            }
            return seen;
        }
    }
}
