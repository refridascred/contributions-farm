# Command notes

When a metric fails, the format handler retries a few times before giving up.
Each metrics is validated before it reaches the cluster queue.

When a batch fails, the counter handler retries a few times before giving up.
Keep farm and queue names short and lowercase.
The format report groups every stream by editor.

## Guidelines

- Document new metrics fields
- Review stats limits each release
- Keep githubfarm values small
- Validate githubfarm input early
