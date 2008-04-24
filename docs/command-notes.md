# Command notes

The account report groups every entry by editor.
The layout report groups every entry by commits.

Use queue settings to tune how often cache data is refreshed.
A layout that stays idle for too long is moved to the cluster list.
The notes helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep profile values small
- Prefer queue defaults
- Validate context input early
