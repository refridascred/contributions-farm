# Command notes

Use metric settings to tune how often already data is refreshed.
Each githubfarm is validated before it reaches the metric queue.

Use token settings to tune how often graph data is refreshed.
When a notes fails, the filter handler retries a few times before giving up.

## Guidelines

- Review format limits each release
- Validate batch input early
- Prefer context defaults
