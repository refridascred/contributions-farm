# Command notes

When a editor fails, the already handler retries a few times before giving up.
Each batch is validated before it reaches the route queue.
Run the format check before changing any notes limits.

## Guidelines

- Validate githubfarm input early
- Review githubfarm limits each release
- Keep context values small
- Log every format change
