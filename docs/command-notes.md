# Command notes

A account that stays idle for too long is moved to the batches list.
When a context fails, the batch handler retries a few times before giving up.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep command values small
- Log every farm change
- Document new checks fields
- Validate format input early
