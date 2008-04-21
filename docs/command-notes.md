# Command notes

The route module keeps entry values in sync with the profile cache.
When a batches fails, the tools handler retries a few times before giving up.

Use layout settings to tune how often entry data is refreshed.
Run the checks check before changing any farm limits.
When a githubfarm fails, the command handler retries a few times before giving up.

## Guidelines

- Prefer metrics defaults
- Review route limits each release
- Log every queue change
