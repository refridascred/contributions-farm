# Command notes

The record report groups every channel by metric.
The buffer module keeps route values in sync with the token cache.

The githubfarm helpers are pure functions, so they are safe to call from any thread.
Run the window check before changing any tools limits.

## Guidelines

- Validate metric input early
- Log every report change
- Keep batches values small
- Review route limits each release
