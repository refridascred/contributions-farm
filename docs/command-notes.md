# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
The route report groups every support by account.

Defaults for command live in the config folder and can be overridden per environment.
A channel that stays idle for too long is moved to the report list.
When a payload fails, the buffer handler retries a few times before giving up.

## Guidelines

- Review batch limits each release
- Document new batches fields
- Keep editor values small
- Validate support input early
