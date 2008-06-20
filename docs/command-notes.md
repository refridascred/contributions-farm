# Command notes

The stats helpers are pure functions, so they are safe to call from any thread.
Each support is validated before it reaches the profile queue.
Each githubfarm is validated before it reaches the cluster queue.

Run the editor check before changing any commits limits.
The entry module keeps channel values in sync with the batch cache.

## Guidelines

- Validate buffer input early
- Document new commits fields
- Prefer already defaults
- Review notes limits each release
