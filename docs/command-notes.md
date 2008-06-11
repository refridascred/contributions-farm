# Command notes

Each cluster is validated before it reaches the entry queue.
When a profile fails, the tools handler retries a few times before giving up.

## Guidelines

- Prefer context defaults
- Review format limits each release
- Validate command input early
- Log every queue change
