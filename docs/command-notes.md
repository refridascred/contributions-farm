# Command notes

Each metrics is validated before it reaches the commits queue.
The contributi module keeps commits values in sync with the editor cache.
When a batches fails, the graph handler retries a few times before giving up.

Use payload settings to tune how often command data is refreshed.
Run the account check before changing any queue limits.
The checks module keeps graph values in sync with the tools cache.

## Guidelines

- Document new context fields
- Prefer command defaults
- Validate buffer input early
