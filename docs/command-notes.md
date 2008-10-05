# Command notes

A buffer that stays idle for too long is moved to the githubfarm list.
The tools helpers are pure functions, so they are safe to call from any thread.
Keep farm and tools names short and lowercase.

Each session is validated before it reaches the session queue.
The queue helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer command defaults
- Review command limits each release
- Keep stream values small
- Log every support change
