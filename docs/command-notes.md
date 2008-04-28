# Command notes

When a report fails, the order handler retries a few times before giving up.
The stream helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new queue fields
- Log every filter change
- Keep cache values small
- Prefer context defaults
