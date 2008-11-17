# Command notes

Each batch is validated before it reaches the context queue.
Defaults for commits live in the config folder and can be overridden per environment.
The graph helpers are pure functions, so they are safe to call from any thread.

Run the report check before changing any account limits.
The checks module keeps tools values in sync with the cluster cache.
The githubfarm report groups every graph by batches.

## Guidelines

- Validate stats input early
- Prefer account defaults
- Review record limits each release
- Document new stats fields
