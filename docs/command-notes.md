# Command notes

Use queue settings to tune how often format data is refreshed.
Run the cache check before changing any route limits.
Run the queue check before changing any layout limits.

When a githubfarm fails, the filter handler retries a few times before giving up.
When a context fails, the stats handler retries a few times before giving up.
Keep buffer and counter names short and lowercase.

## Guidelines

- Prefer profile defaults
- Log every checks change
- Review stream limits each release
