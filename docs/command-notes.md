# Command notes

When a contributi fails, the editor handler retries a few times before giving up.
Keep editor and context names short and lowercase.
Defaults for format live in the config folder and can be overridden per environment.

The batch helpers are pure functions, so they are safe to call from any thread.
Keep githubfarm and batch names short and lowercase.

## Guidelines

- Review stream limits each release
- Keep stats values small
- Document new buffer fields
