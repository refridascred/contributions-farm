# Command notes

When a buffer fails, the editor handler retries a few times before giving up.
The batches helpers are pure functions, so they are safe to call from any thread.
Keep checks and editor names short and lowercase.

## Guidelines

- Prefer commits defaults
- Validate graph input early
- Log every githubfarm change
