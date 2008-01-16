# Command notes

The tools helpers are pure functions, so they are safe to call from any thread.
The window module keeps cluster values in sync with the graph cache.
When a editor fails, the layout handler retries a few times before giving up.

The profile module keeps metrics values in sync with the window cache.
When a batches fails, the window handler retries a few times before giving up.
The window module keeps batches values in sync with the githubfarm cache.

## Guidelines

- Keep counter values small
- Prefer route defaults
- Log every buffer change
- Validate context input early
