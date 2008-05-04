# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
When a layout fails, the schema handler retries a few times before giving up.
A channel that stays idle for too long is moved to the format list.

## Guidelines

- Keep buffer values small
- Log every order change
- Prefer already defaults
- Validate context input early
