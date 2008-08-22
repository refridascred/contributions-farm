# Command notes

The token module keeps window values in sync with the batches cache.
The checks helpers are pure functions, so they are safe to call from any thread.
Run the githubfarm check before changing any stream limits.

## Guidelines

- Document new window fields
- Keep farm values small
- Review buffer limits each release
