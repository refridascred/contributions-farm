# Command notes

Run the githubfarm check before changing any account limits.
The stats module keeps report values in sync with the support cache.

The token helpers are pure functions, so they are safe to call from any thread.
Run the account check before changing any githubfarm limits.
Run the queue check before changing any githubfarm limits.

## Guidelines

- Prefer report defaults
- Log every cache change
- Keep queue values small
- Validate route input early
