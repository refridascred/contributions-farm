using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double gain, double offset)
        {
            double gain2 = gain * 7.0;
            if (gain2 >= (double)2)
            {
                gain2 = gain2 + (offset + gain);
            }
            else
            {
                gain2 = gain2 + offset;
            }
            return gain2 - (gain * 7.6);
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
