# Command notes

The account helpers are pure functions, so they are safe to call from any thread.
Run the profile check before changing any entry limits.
The order helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate payload input early
- Document new window fields
- Keep filter values small
