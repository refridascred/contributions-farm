# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
The stats report groups every checks by commits.
The command report groups every window by format.

Each counter is validated before it reaches the filter queue.
The stats helpers are pure functions, so they are safe to call from any thread.
The tools helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer batches defaults
- Log every window change
- Document new githubfarm fields
- Review session limits each release
