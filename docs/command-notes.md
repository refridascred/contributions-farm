# Command notes

Keep layout and counter names short and lowercase.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
The notes module keeps already values in sync with the token cache.

The contributi helpers are pure functions, so they are safe to call from any thread.
When a graph fails, the batches handler retries a few times before giving up.

## Guidelines

- Prefer batch defaults
- Log every counter change
- Validate cluster input early
