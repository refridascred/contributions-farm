# Command notes

Use stats settings to tune how often batches data is refreshed.
When a graph fails, the stream handler retries a few times before giving up.

The support module keeps window values in sync with the order cache.
A githubfarm that stays idle for too long is moved to the buffer list.
Keep command and context names short and lowercase.

## Guidelines

- Prefer account defaults
- Validate account input early
- Keep metrics values small
