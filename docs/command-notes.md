# Command notes

The farm module keeps githubfarm values in sync with the commits cache.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate counter input early
- Document new checks fields
- Keep notes values small
