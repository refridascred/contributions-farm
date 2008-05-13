# Command notes

Run the channel check before changing any counter limits.
Run the route check before changing any stream limits.
A format that stays idle for too long is moved to the tools list.

The already helpers are pure functions, so they are safe to call from any thread.
The token helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every metric change
- Validate checks input early
- Keep format values small
