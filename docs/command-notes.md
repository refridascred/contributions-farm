# Command notes

The account helpers are pure functions, so they are safe to call from any thread.
A token that stays idle for too long is moved to the layout list.

## Guidelines

- Log every tools change
- Document new session fields
- Validate stream input early
- Prefer stats defaults
