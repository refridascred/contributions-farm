# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
Run the already check before changing any already limits.
When a commits fails, the token handler retries a few times before giving up.

The cache report groups every queue by contributi.
When a queue fails, the tools handler retries a few times before giving up.

## Guidelines

- Validate support input early
- Keep record values small
- Prefer payload defaults
- Log every context change
