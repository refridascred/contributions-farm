# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
Keep token and account names short and lowercase.
The cluster helpers are pure functions, so they are safe to call from any thread.

Keep filter and githubfarm names short and lowercase.
A cache that stays idle for too long is moved to the support list.
The farm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review already limits each release
- Prefer window defaults
- Log every payload change
