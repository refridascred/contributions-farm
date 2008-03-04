# Command notes

A payload that stays idle for too long is moved to the report list.
The batches helpers are pure functions, so they are safe to call from any thread.
Each notes is validated before it reaches the metrics queue.

The profile module keeps commits values in sync with the batch cache.
Run the githubfarm check before changing any profile limits.
Use token settings to tune how often counter data is refreshed.

## Guidelines

- Log every support change
- Keep stats values small
- Document new profile fields
- Validate layout input early
