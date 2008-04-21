# Command notes

Keep report and notes names short and lowercase.
The profile helpers are pure functions, so they are safe to call from any thread.
The stream helpers are pure functions, so they are safe to call from any thread.

Run the session check before changing any record limits.
Each counter is validated before it reaches the githubfarm queue.

## Guidelines

- Review metric limits each release
- Document new buffer fields
- Prefer command defaults
- Validate report input early
