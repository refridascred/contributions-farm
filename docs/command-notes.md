# Command notes

Use format settings to tune how often cluster data is refreshed.
The support module keeps counter values in sync with the checks cache.

The account helpers are pure functions, so they are safe to call from any thread.
The buffer report groups every window by account.
The githubfarm module keeps batch values in sync with the metric cache.

## Guidelines

- Keep queue values small
- Document new payload fields
- Log every editor change
