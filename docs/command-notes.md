# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
When a commits fails, the batches handler retries a few times before giving up.
Use schema settings to tune how often order data is refreshed.

## Guidelines

- Document new commits fields
- Keep layout values small
- Prefer stats defaults
- Review metric limits each release
