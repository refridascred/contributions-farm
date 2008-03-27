# Command notes

Use githubfarm settings to tune how often layout data is refreshed.
Each batches is validated before it reaches the account queue.
Run the profile check before changing any context limits.

The buffer helpers are pure functions, so they are safe to call from any thread.
Each notes is validated before it reaches the checks queue.
The already module keeps already values in sync with the already cache.

## Guidelines

- Prefer buffer defaults
- Document new support fields
- Keep command values small
- Validate notes input early
