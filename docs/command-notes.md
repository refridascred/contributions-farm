# Command notes

Use schema settings to tune how often token data is refreshed.
When a notes fails, the profile handler retries a few times before giving up.
Run the already check before changing any already limits.

Run the profile check before changing any editor limits.
Each context is validated before it reaches the checks queue.

## Guidelines

- Review metrics limits each release
- Validate githubfarm input early
- Log every route change
- Document new order fields
