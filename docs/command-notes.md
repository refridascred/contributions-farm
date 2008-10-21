# Command notes

When a window fails, the farm handler retries a few times before giving up.
When a format fails, the cluster handler retries a few times before giving up.

When a entry fails, the cache handler retries a few times before giving up.
Use stats settings to tune how often editor data is refreshed.
The profile module keeps stats values in sync with the githubfarm cache.

## Guidelines

- Review tools limits each release
- Keep metric values small
- Prefer schema defaults
