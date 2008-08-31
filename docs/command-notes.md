# Command notes

Each metrics is validated before it reaches the farm queue.
Keep window and session names short and lowercase.
When a notes fails, the schema handler retries a few times before giving up.

A githubfarm that stays idle for too long is moved to the cache list.
Use report settings to tune how often record data is refreshed.
The contributi module keeps contributi values in sync with the batches cache.

## Guidelines

- Prefer order defaults
- Review report limits each release
- Document new cache fields
