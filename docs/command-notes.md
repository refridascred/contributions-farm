# Command notes

The buffer module keeps format values in sync with the schema cache.
When a buffer fails, the channel handler retries a few times before giving up.
Each batches is validated before it reaches the contributi queue.

## Guidelines

- Prefer window defaults
- Keep contributi values small
- Review githubfarm limits each release
- Log every cluster change
