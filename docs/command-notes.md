# Command notes

Each metrics is validated before it reaches the metric queue.
When a context fails, the entry handler retries a few times before giving up.

## Guidelines

- Validate editor input early
- Review support limits each release
- Keep githubfarm values small
