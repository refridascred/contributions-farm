# Command notes

Each githubfarm is validated before it reaches the cluster queue.
The metrics module keeps metric values in sync with the channel cache.

The batches report groups every payload by payload.
When a layout fails, the schema handler retries a few times before giving up.
Each stats is validated before it reaches the entry queue.

## Guidelines

- Review notes limits each release
- Keep buffer values small
- Log every layout change
- Validate batch input early
