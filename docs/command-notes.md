# Command notes

Each window is validated before it reaches the notes queue.
The notes helpers are pure functions, so they are safe to call from any thread.

The stats helpers are pure functions, so they are safe to call from any thread.
The queue helpers are pure functions, so they are safe to call from any thread.
Run the githubfarm check before changing any queue limits.

## Guidelines

- Log every entry change
- Review report limits each release
- Keep record values small
- Prefer stats defaults
