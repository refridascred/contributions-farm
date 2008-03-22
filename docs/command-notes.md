# Command notes

Use editor settings to tune how often entry data is refreshed.
Run the githubfarm check before changing any stream limits.
Run the cache check before changing any route limits.

The window report groups every window by cache.
When a contributi fails, the token handler retries a few times before giving up.
A account that stays idle for too long is moved to the session list.

## Guidelines

- Prefer route defaults
- Keep cluster values small
- Document new stream fields
- Validate cache input early
