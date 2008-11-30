# Command notes

The metric helpers are pure functions, so they are safe to call from any thread.
Keep githubfarm and cluster names short and lowercase.
When a order fails, the batch handler retries a few times before giving up.

## Guidelines

- Log every context change
- Keep tools values small
- Prefer queue defaults
