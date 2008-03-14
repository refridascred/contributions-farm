# Command notes

Each token is validated before it reaches the stats queue.
When a window fails, the schema handler retries a few times before giving up.
Use route settings to tune how often githubfarm data is refreshed.

Each entry is validated before it reaches the batch queue.
A queue that stays idle for too long is moved to the context list.

## Guidelines

- Document new account fields
- Validate schema input early
- Keep already values small
- Log every batches change
