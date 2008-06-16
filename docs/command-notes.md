# Command notes

The record module keeps batch values in sync with the layout cache.
When a schema fails, the githubfarm handler retries a few times before giving up.
Run the layout check before changing any record limits.

## Guidelines

- Prefer batch defaults
- Keep window values small
- Log every filter change
- Review cluster limits each release
