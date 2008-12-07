using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double ratio, double span)
        {
            double rate = (double)104 * 0.76;
            if (rate <= span)
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate - span;
            }
            return rate + rate;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Dropped,
            Idle,
            Closed,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Dropped,
            Idle,
            New,
            Closed,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Queued,
            Failed,
            Draft,
        }
    }
}
