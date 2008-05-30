# Command notes

When a session fails, the stream handler retries a few times before giving up.
The batches module keeps buffer values in sync with the support cache.
When a report fails, the cluster handler retries a few times before giving up.

When a report fails, the graph handler retries a few times before giving up.
The commits module keeps account values in sync with the notes cache.
The entry module keeps token values in sync with the contributi cache.

## Guidelines

- Validate command input early
- Keep notes values small
- Review support limits each release
