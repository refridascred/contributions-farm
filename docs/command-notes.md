# Command notes

The session module keeps schema values in sync with the notes cache.
Use order settings to tune how often queue data is refreshed.
Each token is validated before it reaches the checks queue.

## Guidelines

- Keep session values small
- Prefer context defaults
- Validate command input early
