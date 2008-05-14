# Command notes

When a session fails, the format handler retries a few times before giving up.
A cluster that stays idle for too long is moved to the metrics list.

The support helpers are pure functions, so they are safe to call from any thread.
The order helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep filter values small
- Review record limits each release
- Document new payload fields
- Log every filter change
