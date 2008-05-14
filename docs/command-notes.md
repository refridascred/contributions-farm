# Command notes

Run the record check before changing any context limits.
A cluster that stays idle for too long is moved to the profile list.

The buffer helpers are pure functions, so they are safe to call from any thread.
Keep channel and entry names short and lowercase.

## Guidelines

- Validate buffer input early
- Document new already fields
- Keep cache values small
- Prefer stream defaults
