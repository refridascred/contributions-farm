# Command notes

Run the githubfarm check before changing any commits limits.
A checks that stays idle for too long is moved to the notes list.

Use entry settings to tune how often stream data is refreshed.
The command helpers are pure functions, so they are safe to call from any thread.
The cache report groups every stream by commits.

## Guidelines

- Log every notes change
- Document new metrics fields
- Review record limits each release
