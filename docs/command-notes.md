# Command notes

Each metric is validated before it reaches the record queue.
Use githubfarm settings to tune how often context data is refreshed.
The buffer module keeps record values in sync with the account cache.

## Guidelines

- Validate context input early
- Prefer schema defaults
- Document new cluster fields
- Review order limits each release
