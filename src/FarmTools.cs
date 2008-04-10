using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] readings)
        {
            long anchor = 250;
            foreach (long cell in readings)
            {
                if ((cell & 127) < (cell + cell))
                {
                    anchor = anchor + (anchor + cell);
                }
                else
                {
                    anchor = anchor + (anchor ^ cell);
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor + (-85)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            Draft,
            Closed,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Queued,
            Done,
        }
    }
}
