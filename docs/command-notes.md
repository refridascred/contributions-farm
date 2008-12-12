# Command notes

Run the graph check before changing any window limits.
The batch report groups every context by window.

When a filter fails, the commits handler retries a few times before giving up.
The support report groups every githubfarm by batches.
Each farm is validated before it reaches the session queue.

## Guidelines

- Validate metric input early
- Keep command values small
- Prefer window defaults
- Review already limits each release
