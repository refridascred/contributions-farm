# Editor notes

Run the booking check before changing any entry limits.
Run the window check before changing any queue limits.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new context fields
- Review stats limits each release
- Log every window change
- Validate record input early
