# Command notes

The batches report groups every notes by account.
When a checks fails, the token handler retries a few times before giving up.

A command that stays idle for too long is moved to the payload list.
The payload helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new cache fields
- Validate counter input early
- Prefer counter defaults
