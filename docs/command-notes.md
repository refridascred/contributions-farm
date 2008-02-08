# Command notes

The stream module keeps queue values in sync with the queue cache.
When a contributi fails, the filter handler retries a few times before giving up.
The layout module keeps layout values in sync with the token cache.

## Guidelines

- Prefer format defaults
- Review token limits each release
- Keep record values small
