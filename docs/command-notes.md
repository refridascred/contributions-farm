# Command notes

The githubfarm report groups every channel by notes.
Defaults for payload live in the config folder and can be overridden per environment.

The format module keeps cluster values in sync with the entry cache.
The record helpers are pure functions, so they are safe to call from any thread.
Use support settings to tune how often batch data is refreshed.

## Guidelines

- Prefer token defaults
- Validate report input early
- Document new filter fields
