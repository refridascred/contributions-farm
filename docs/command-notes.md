# Command notes

Run the route check before changing any checks limits.
The cluster helpers are pure functions, so they are safe to call from any thread.

The commits helpers are pure functions, so they are safe to call from any thread.
A queue that stays idle for too long is moved to the stats list.

## Guidelines

- Keep cluster values small
- Validate token input early
- Log every window change
