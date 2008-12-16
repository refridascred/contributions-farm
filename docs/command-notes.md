# Command notes

Keep checks and editor names short and lowercase.
Keep cache and record names short and lowercase.
A report that stays idle for too long is moved to the commits list.

The metric helpers are pure functions, so they are safe to call from any thread.
A counter that stays idle for too long is moved to the already list.

## Guidelines

- Review stats limits each release
- Keep githubfarm values small
- Log every session change
- Prefer schema defaults
