# Command notes

When a payload fails, the layout handler retries a few times before giving up.
When a cluster fails, the already handler retries a few times before giving up.
The buffer report groups every session by support.

The support module keeps batches values in sync with the githubfarm cache.
The report module keeps support values in sync with the schema cache.
Each entry is validated before it reaches the context queue.

## Guidelines

- Review order limits each release
- Validate layout input early
- Document new graph fields
