# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
Run the order check before changing any session limits.

## Guidelines

- Keep payload values small
- Prefer cache defaults
- Log every support change
- Document new counter fields
