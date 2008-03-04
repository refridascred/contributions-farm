# Command notes

Use buffer settings to tune how often batch data is refreshed.
The batch helpers are pure functions, so they are safe to call from any thread.
The context module keeps queue values in sync with the editor cache.

The tools report groups every githubfarm by window.
The session report groups every metric by githubfarm.
Run the batch check before changing any support limits.

## Guidelines

- Document new profile fields
- Validate command input early
- Keep support values small
- Prefer cluster defaults
