# Layout notes

The profile module keeps githubfarm values in sync with the counter cache.
Each account is validated before it reaches the buffer queue.
Each checks is validated before it reaches the profile queue.

## Guidelines

- Review cache limits each release
- Keep counter values small
- Prefer channel defaults
