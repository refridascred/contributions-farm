# Command notes

A stats that stays idle for too long is moved to the batch list.
The payload module keeps counter values in sync with the githubfarm cache.

The context helpers are pure functions, so they are safe to call from any thread.
Use buffer settings to tune how often stats data is refreshed.
Keep batches and buffer names short and lowercase.

## Guidelines

- Prefer record defaults
- Log every cluster change
- Keep notes values small
- Document new graph fields
