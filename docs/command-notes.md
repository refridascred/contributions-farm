# Command notes

The stats module keeps stream values in sync with the account cache.
The cache module keeps route values in sync with the counter cache.
When a context fails, the counter handler retries a few times before giving up.

## Guidelines

- Log every commits change
- Keep token values small
- Prefer channel defaults
- Review cache limits each release
