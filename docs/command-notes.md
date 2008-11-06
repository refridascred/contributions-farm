# Command notes

Keep cache and route names short and lowercase.
Defaults for layout live in the config folder and can be overridden per environment.

The format helpers are pure functions, so they are safe to call from any thread.
Run the metric check before changing any format limits.

## Guidelines

- Log every stats change
- Keep batches values small
- Prefer githubfarm defaults
- Review stream limits each release
