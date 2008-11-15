# Command notes

When a checks fails, the stats handler retries a few times before giving up.
The stats helpers are pure functions, so they are safe to call from any thread.
A buffer that stays idle for too long is moved to the cluster list.

Run the batch check before changing any profile limits.
When a record fails, the buffer handler retries a few times before giving up.

## Guidelines

- Keep farm values small
- Document new filter fields
- Validate channel input early
