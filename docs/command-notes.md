# Command notes

Run the buffer check before changing any payload limits.
The cluster module keeps contributi values in sync with the profile cache.

Run the githubfarm check before changing any command limits.
Each support is validated before it reaches the report queue.
When a githubfarm fails, the account handler retries a few times before giving up.

## Guidelines

- Review checks limits each release
- Prefer contributi defaults
- Log every batches change
