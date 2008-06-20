# Command notes

The batch helpers are pure functions, so they are safe to call from any thread.
Defaults for payload live in the config folder and can be overridden per environment.

The window report groups every githubfarm by queue.
Use cluster settings to tune how often format data is refreshed.

## Guidelines

- Review batch limits each release
- Log every checks change
- Keep checks values small
