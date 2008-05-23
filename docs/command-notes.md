# Command notes

The editor module keeps entry values in sync with the format cache.
Run the commits check before changing any stream limits.
Each batches is validated before it reaches the format queue.

When a tools fails, the stats handler retries a few times before giving up.
Run the report check before changing any channel limits.
Keep graph and githubfarm names short and lowercase.

## Guidelines

- Prefer route defaults
- Document new counter fields
- Log every queue change
