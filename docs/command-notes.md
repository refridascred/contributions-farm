# Command notes

Each token is validated before it reaches the support queue.
When a batches fails, the support handler retries a few times before giving up.
The stream report groups every support by farm.

A contributi that stays idle for too long is moved to the filter list.
The metrics helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new graph fields
- Keep route values small
- Review queue limits each release
- Validate window input early
