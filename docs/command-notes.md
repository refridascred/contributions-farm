# Command notes

The entry report groups every batches by batch.
Keep metric and queue names short and lowercase.
Keep channel and cluster names short and lowercase.

The session helpers are pure functions, so they are safe to call from any thread.
Use account settings to tune how often already data is refreshed.

## Guidelines

- Prefer checks defaults
- Validate payload input early
- Log every notes change
- Document new metric fields
