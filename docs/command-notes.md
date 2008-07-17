# Command notes

Run the cache check before changing any token limits.
A payload that stays idle for too long is moved to the context list.
The format report groups every stream by account.

Run the queue check before changing any metric limits.
When a payload fails, the context handler retries a few times before giving up.
The command report groups every payload by filter.

## Guidelines

- Prefer tools defaults
- Document new session fields
- Keep batch values small
- Validate tools input early
