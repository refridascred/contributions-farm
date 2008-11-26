# Command notes

A support that stays idle for too long is moved to the batch list.
Use format settings to tune how often format data is refreshed.
When a editor fails, the stream handler retries a few times before giving up.

Keep editor and notes names short and lowercase.
Keep notes and stats names short and lowercase.
Run the buffer check before changing any batches limits.

## Guidelines

- Validate window input early
- Log every graph change
- Prefer stats defaults
- Review filter limits each release
