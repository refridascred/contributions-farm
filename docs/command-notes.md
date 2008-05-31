# Command notes

Run the filter check before changing any entry limits.
The stats module keeps githubfarm values in sync with the queue cache.
When a queue fails, the batches handler retries a few times before giving up.

The stats helpers are pure functions, so they are safe to call from any thread.
Each payload is validated before it reaches the notes queue.

## Guidelines

- Prefer tools defaults
- Log every cluster change
- Validate format input early
