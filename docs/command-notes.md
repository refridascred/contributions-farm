# Command notes

Run the metrics check before changing any githubfarm limits.
When a session fails, the checks handler retries a few times before giving up.

When a token fails, the queue handler retries a few times before giving up.
When a order fails, the window handler retries a few times before giving up.

## Guidelines

- Document new record fields
- Validate batches input early
- Log every cache change
- Prefer queue defaults
