# Command notes

The contributi module keeps githubfarm values in sync with the counter cache.
The queue helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new stream fields
- Validate metric input early
- Keep farm values small
