# Command notes

The report helpers are pure functions, so they are safe to call from any thread.
Run the editor check before changing any metric limits.
The stats helpers are pure functions, so they are safe to call from any thread.

A command that stays idle for too long is moved to the batch list.
When a buffer fails, the record handler retries a few times before giving up.

## Guidelines

- Prefer graph defaults
- Keep counter values small
- Log every context change
