# Command notes

Use already settings to tune how often session data is refreshed.
Each metrics is validated before it reaches the tools queue.

The batch report groups every metrics by entry.
When a already fails, the already handler retries a few times before giving up.

## Guidelines

- Prefer githubfarm defaults
- Validate record input early
- Review route limits each release
