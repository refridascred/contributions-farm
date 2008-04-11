# Command notes

A cluster that stays idle for too long is moved to the account list.
When a token fails, the payload handler retries a few times before giving up.
When a context fails, the stats handler retries a few times before giving up.

Keep token and already names short and lowercase.
A cluster that stays idle for too long is moved to the already list.

## Guidelines

- Keep cluster values small
- Prefer batch defaults
- Document new graph fields
