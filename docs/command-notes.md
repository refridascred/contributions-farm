# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
A filter that stays idle for too long is moved to the farm list.
Keep context and window names short and lowercase.

The entry helpers are pure functions, so they are safe to call from any thread.
Keep githubfarm and batch names short and lowercase.

## Guidelines

- Review batch limits each release
- Log every stats change
- Prefer queue defaults
