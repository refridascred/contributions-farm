# Command notes

A profile that stays idle for too long is moved to the token list.
The cache module keeps format values in sync with the githubfarm cache.
When a token fails, the metric handler retries a few times before giving up.

## Guidelines

- Log every stats change
- Keep filter values small
- Review route limits each release
- Prefer schema defaults
