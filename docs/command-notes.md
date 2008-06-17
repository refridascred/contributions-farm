# Command notes

Use account settings to tune how often account data is refreshed.
When a payload fails, the graph handler retries a few times before giving up.
Each notes is validated before it reaches the checks queue.

## Guidelines

- Review profile limits each release
- Keep metric values small
- Validate checks input early
- Prefer route defaults
