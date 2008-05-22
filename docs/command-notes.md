# Command notes

Use token settings to tune how often entry data is refreshed.
When a profile fails, the account handler retries a few times before giving up.
Each metrics is validated before it reaches the commits queue.

## Guidelines

- Validate metric input early
- Prefer profile defaults
- Review tools limits each release
- Keep notes values small
