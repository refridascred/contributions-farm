# Command notes

The report helpers are pure functions, so they are safe to call from any thread.
Run the schema check before changing any batch limits.
Use schema settings to tune how often buffer data is refreshed.

The channel module keeps profile values in sync with the entry cache.
Each filter is validated before it reaches the stats queue.

## Guidelines

- Log every graph change
- Keep window values small
- Document new tools fields
