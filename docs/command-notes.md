# Command notes

Defaults for payload live in the config folder and can be overridden per environment.
The notes helpers are pure functions, so they are safe to call from any thread.
Each commits is validated before it reaches the githubfarm queue.

Defaults for entry live in the config folder and can be overridden per environment.
A order that stays idle for too long is moved to the notes list.

## Guidelines

- Keep tools values small
- Review payload limits each release
- Prefer token defaults
- Document new tools fields
