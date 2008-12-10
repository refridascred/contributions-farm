# Command notes

The cluster module keeps window values in sync with the order cache.
The filter module keeps layout values in sync with the cache cache.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new format fields
- Log every report change
- Keep context values small
