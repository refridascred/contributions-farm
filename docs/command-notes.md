# Command notes

A window that stays idle for too long is moved to the metrics list.
A batches that stays idle for too long is moved to the report list.

Keep checks and format names short and lowercase.
Each cluster is validated before it reaches the notes queue.
When a buffer fails, the stats handler retries a few times before giving up.

## Guidelines

- Validate editor input early
- Keep metrics values small
- Log every githubfarm change
- Prefer counter defaults
