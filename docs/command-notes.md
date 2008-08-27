# Command notes

When a token fails, the tools handler retries a few times before giving up.
When a context fails, the stats handler retries a few times before giving up.
The account module keeps counter values in sync with the tools cache.

## Guidelines

- Log every counter change
- Prefer session defaults
- Review stream limits each release
- Keep window values small
