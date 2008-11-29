# Command notes

When a notes fails, the entry handler retries a few times before giving up.
A counter that stays idle for too long is moved to the commits list.

Keep order and window names short and lowercase.
The command module keeps filter values in sync with the window cache.

## Guidelines

- Review tools limits each release
- Prefer schema defaults
- Keep token values small
- Document new queue fields
