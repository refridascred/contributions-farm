# Command notes

The cluster module keeps batch values in sync with the githubfarm cache.
The editor helpers are pure functions, so they are safe to call from any thread.

Each farm is validated before it reaches the account queue.
Use order settings to tune how often format data is refreshed.

## Guidelines

- Prefer checks defaults
- Log every filter change
- Keep cache values small
- Validate profile input early
