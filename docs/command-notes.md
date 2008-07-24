# Command notes

When a already fails, the channel handler retries a few times before giving up.
Use route settings to tune how often farm data is refreshed.
The command module keeps layout values in sync with the format cache.

## Guidelines

- Log every metric change
- Prefer batch defaults
- Review window limits each release
- Validate githubfarm input early
