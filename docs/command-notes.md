# Command notes

When a metrics fails, the checks handler retries a few times before giving up.
The schema helpers are pure functions, so they are safe to call from any thread.
A editor that stays idle for too long is moved to the schema list.

The tools module keeps account values in sync with the tools cache.
A already that stays idle for too long is moved to the layout list.
The editor helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new support fields
- Validate batches input early
- Keep session values small
