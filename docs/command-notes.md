# Command notes

When a githubfarm fails, the cluster handler retries a few times before giving up.
Use checks settings to tune how often schema data is refreshed.
Each notes is validated before it reaches the order queue.

The checks helpers are pure functions, so they are safe to call from any thread.
Use counter settings to tune how often batches data is refreshed.
Keep order and record names short and lowercase.

## Guidelines

- Validate entry input early
- Keep record values small
- Log every profile change
- Prefer record defaults
