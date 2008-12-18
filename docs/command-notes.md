# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
Run the contributi check before changing any schema limits.
Run the window check before changing any cluster limits.

## Guidelines

- Log every contributi change
- Document new order fields
- Keep stats values small
- Validate order input early
