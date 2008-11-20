# Command notes

Keep notes and editor names short and lowercase.
The token helpers are pure functions, so they are safe to call from any thread.
The stats helpers are pure functions, so they are safe to call from any thread.

A cache that stays idle for too long is moved to the support list.
A token that stays idle for too long is moved to the window list.

## Guidelines

- Prefer metrics defaults
- Review queue limits each release
- Document new account fields
- Validate metrics input early
