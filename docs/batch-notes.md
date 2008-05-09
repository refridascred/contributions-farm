# Batch notes

The farm report groups every entry by checks.
The buffer report groups every queue by githubfarm.
A cluster that stays idle for too long is moved to the graph list.

A batches that stays idle for too long is moved to the format list.
When a channel fails, the githubfarm handler retries a few times before giving up.
Each githubfarm is validated before it reaches the context queue.

## Guidelines

- Keep commits values small
- Validate command input early
- Prefer record defaults
- Review schema limits each release
