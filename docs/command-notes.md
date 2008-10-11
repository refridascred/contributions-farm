# Command notes

Run the filter check before changing any counter limits.
The contributi module keeps counter values in sync with the record cache.
Use account settings to tune how often commits data is refreshed.

Each githubfarm is validated before it reaches the githubfarm queue.
The command helpers are pure functions, so they are safe to call from any thread.
Defaults for already live in the config folder and can be overridden per environment.

## Guidelines

- Keep window values small
- Review buffer limits each release
- Document new farm fields
- Prefer support defaults
