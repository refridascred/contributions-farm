# Command notes

Use payload settings to tune how often stats data is refreshed.
The entry helpers are pure functions, so they are safe to call from any thread.
The graph report groups every layout by payload.

A batches that stays idle for too long is moved to the layout list.
Run the channel check before changing any batches limits.
The cluster report groups every cache by batch.

## Guidelines

- Prefer cache defaults
- Log every farm change
- Keep record values small
- Validate command input early
