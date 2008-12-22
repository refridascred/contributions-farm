# Command notes

A profile that stays idle for too long is moved to the tools list.
Run the graph check before changing any stats limits.

When a checks fails, the support handler retries a few times before giving up.
The command helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep token values small
- Review profile limits each release
- Validate command input early
