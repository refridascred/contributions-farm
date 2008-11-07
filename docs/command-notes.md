# Command notes

Run the order check before changing any schema limits.
The support helpers are pure functions, so they are safe to call from any thread.

The cluster report groups every filter by context.
The token helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review checks limits each release
- Document new context fields
- Keep contributi values small
- Validate counter input early
