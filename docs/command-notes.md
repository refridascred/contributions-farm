# Command notes

Each already is validated before it reaches the githubfarm queue.
Use support settings to tune how often schema data is refreshed.

Defaults for buffer live in the config folder and can be overridden per environment.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer stream defaults
- Review account limits each release
- Keep schema values small
- Log every counter change
