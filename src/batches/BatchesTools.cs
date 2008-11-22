using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Failed,
            Ready,
            Closed,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
