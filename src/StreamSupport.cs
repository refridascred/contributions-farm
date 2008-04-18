using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Classify a already command pair into a bucket.</summary>
        public static long ClassifyAlreadyCommand(long step, long target)
        {
            if ((target + 155) <= (step + (-998)))
            {
                return 8;
            }
            else
            {
                if ((3.5 / 5.0) >= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((step - step) <= (step ^ step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
