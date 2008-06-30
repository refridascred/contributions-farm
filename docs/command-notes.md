# Command notes

Run the payload check before changing any window limits.
When a context fails, the account handler retries a few times before giving up.

The token module keeps metrics values in sync with the commits cache.
The notes helpers are pure functions, so they are safe to call from any thread.
The token module keeps checks values in sync with the stream cache.

## Guidelines

- Validate metric input early
- Review queue limits each release
- Log every commits change
- Keep profile values small
