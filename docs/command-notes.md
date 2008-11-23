# Command notes

When a already fails, the farm handler retries a few times before giving up.
A commits that stays idle for too long is moved to the account list.
The command helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep githubfarm values small
- Review context limits each release
- Prefer account defaults
- Log every window change
