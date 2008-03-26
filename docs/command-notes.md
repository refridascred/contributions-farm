# Command notes

Use checks settings to tune how often commits data is refreshed.
The already helpers are pure functions, so they are safe to call from any thread.
Each record is validated before it reaches the profile queue.

## Guidelines

- Log every window change
- Keep order values small
- Review batches limits each release
- Prefer session defaults
