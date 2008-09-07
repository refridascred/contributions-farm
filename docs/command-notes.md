# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
Each notes is validated before it reaches the notes queue.
Run the format check before changing any support limits.

## Guidelines

- Prefer support defaults
- Review account limits each release
- Keep route values small
- Validate githubfarm input early
