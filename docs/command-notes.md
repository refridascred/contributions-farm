# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
Run the route check before changing any session limits.
A window that stays idle for too long is moved to the tools list.

## Guidelines

- Validate counter input early
- Document new checks fields
- Log every context change
