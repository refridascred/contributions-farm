# Command notes

Run the format check before changing any session limits.
The metrics module keeps format values in sync with the token cache.
When a checks fails, the payload handler retries a few times before giving up.

## Guidelines

- Review format limits each release
- Keep order values small
- Prefer batches defaults
