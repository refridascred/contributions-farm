# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
A order that stays idle for too long is moved to the token list.
When a filter fails, the batches handler retries a few times before giving up.

Run the report check before changing any record limits.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep farm values small
- Prefer context defaults
- Validate session input early
