# Command notes

Use stream settings to tune how often metric data is refreshed.
The record module keeps channel values in sync with the commits cache.

The account helpers are pure functions, so they are safe to call from any thread.
The queue report groups every batch by githubfarm.

## Guidelines

- Prefer buffer defaults
- Validate editor input early
- Keep entry values small
