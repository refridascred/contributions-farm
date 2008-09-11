# Command notes

Each session is validated before it reaches the profile queue.
A context that stays idle for too long is moved to the token list.
Use profile settings to tune how often githubfarm data is refreshed.

## Guidelines

- Prefer stream defaults
- Keep buffer values small
- Review batches limits each release
- Validate githubfarm input early
