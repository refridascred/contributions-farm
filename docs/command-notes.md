# Command notes

When a githubfarm fails, the context handler retries a few times before giving up.
A githubfarm that stays idle for too long is moved to the session list.

## Guidelines

- Prefer notes defaults
- Validate stream input early
- Keep command values small
- Review queue limits each release
