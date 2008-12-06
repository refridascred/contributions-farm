# Command notes

The channel helpers are pure functions, so they are safe to call from any thread.
The metrics module keeps cluster values in sync with the stats cache.

Each report is validated before it reaches the farm queue.
Each layout is validated before it reaches the githubfarm queue.
Each channel is validated before it reaches the metrics queue.

## Guidelines

- Log every contributi change
- Document new stats fields
- Validate batches input early
