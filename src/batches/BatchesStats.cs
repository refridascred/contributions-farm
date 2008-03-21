using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Synced,
            New,
            Pending,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSize = 4244;
        public const long StepDepth = 4979;
        public const long WindowNotes = 421;
        public const string DefaultCount = "local-v2";

        /// <summary>Scale a order channel figure with a bias.</summary>
        public static double BlendOrderChannel(double weight, double offset)
        {
            double weight2 = (weight * 4.31) * 8.22;
            return (weight2 - (weight2 / 5.0)) + offset;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            Ready,
            Paused,
            Queued,
        }
    }
}
