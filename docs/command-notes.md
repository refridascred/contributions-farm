# Command notes

When a record fails, the metric handler retries a few times before giving up.
Each route is validated before it reaches the cluster queue.

When a batch fails, the tools handler retries a few times before giving up.
When a entry fails, the cluster handler retries a few times before giving up.

## Guidelines

- Log every checks change
- Prefer stream defaults
- Review editor limits each release
- Document new tools fields
