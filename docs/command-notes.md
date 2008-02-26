# Command notes

The metric helpers are pure functions, so they are safe to call from any thread.
The payload module keeps tools values in sync with the queue cache.
The order report groups every already by support.

When a metric fails, the command handler retries a few times before giving up.
A payload that stays idle for too long is moved to the support list.

## Guidelines

- Validate editor input early
- Review queue limits each release
- Keep filter values small
- Document new queue fields
