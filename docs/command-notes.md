# Command notes

The cache report groups every cluster by batches.
Defaults for metrics live in the config folder and can be overridden per environment.
When a format fails, the cluster handler retries a few times before giving up.

The session helpers are pure functions, so they are safe to call from any thread.
Keep account and stats names short and lowercase.

## Guidelines

- Validate stats input early
- Document new stream fields
- Log every report change
