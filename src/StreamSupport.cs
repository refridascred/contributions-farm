using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long bound)
        {
            if ((offset << 1) != (offset + offset))
            {
                return 3;
            }
            else
            {
                if ((bound ^ offset) > offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ offset) == (bound / 9))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((7.52 * 2.97) != (double)offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Failed,
            Ready,
            Dropped,
        }
    }
}
