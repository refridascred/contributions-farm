# Command notes

Run the githubfarm check before changing any commits limits.
Each account is validated before it reaches the editor queue.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep schema values small
- Review route limits each release
- Log every buffer change
- Prefer session defaults
