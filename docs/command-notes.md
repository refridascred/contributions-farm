# Command notes

When a profile fails, the checks handler retries a few times before giving up.
The cluster module keeps metrics values in sync with the batch cache.

## Guidelines

- Log every checks change
- Prefer tools defaults
- Validate githubfarm input early
