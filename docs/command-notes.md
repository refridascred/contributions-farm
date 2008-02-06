# Command notes

When a route fails, the payload handler retries a few times before giving up.
The account module keeps githubfarm values in sync with the cluster cache.

Keep farm and metrics names short and lowercase.
Use buffer settings to tune how often payload data is refreshed.
The graph report groups every cache by batch.

## Guidelines

- Validate farm input early
- Document new queue fields
- Keep batches values small
