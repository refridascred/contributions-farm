# Command notes

The session module keeps queue values in sync with the githubfarm cache.
A stream that stays idle for too long is moved to the batches list.
Use session settings to tune how often order data is refreshed.

A githubfarm that stays idle for too long is moved to the editor list.
Keep metrics and session names short and lowercase.
When a commits fails, the buffer handler retries a few times before giving up.

## Guidelines

- Keep token values small
- Log every cache change
- Validate githubfarm input early
- Prefer payload defaults
