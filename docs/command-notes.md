# Command notes

Use queue settings to tune how often already data is refreshed.
Run the cache check before changing any counter limits.
The support helpers are pure functions, so they are safe to call from any thread.

The notes helpers are pure functions, so they are safe to call from any thread.
The schema module keeps schema values in sync with the githubfarm cache.

## Guidelines

- Review support limits each release
- Document new account fields
- Keep profile values small
- Validate window input early
