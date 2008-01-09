# Command notes

Each report is validated before it reaches the githubfarm queue.
Defaults for profile live in the config folder and can be overridden per environment.
The metrics helpers are pure functions, so they are safe to call from any thread.

Use notes settings to tune how often metrics data is refreshed.
The githubfarm module keeps filter values in sync with the schema cache.
The cluster module keeps command values in sync with the githubfarm cache.

## Guidelines

- Validate notes input early
- Prefer session defaults
- Document new cluster fields
- Keep record values small
