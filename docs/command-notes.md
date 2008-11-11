# Command notes

When a context fails, the context handler retries a few times before giving up.
Use batches settings to tune how often context data is refreshed.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every batches change
- Document new support fields
- Keep farm values small
- Prefer batches defaults
