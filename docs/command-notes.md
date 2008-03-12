# Command notes

When a format fails, the account handler retries a few times before giving up.
Use support settings to tune how often account data is refreshed.
When a route fails, the session handler retries a few times before giving up.

## Guidelines

- Review buffer limits each release
- Log every checks change
- Validate batches input early
- Keep githubfarm values small
