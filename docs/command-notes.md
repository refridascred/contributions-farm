# Command notes

The session module keeps metric values in sync with the entry cache.
Run the githubfarm check before changing any session limits.
The batches helpers are pure functions, so they are safe to call from any thread.

Run the githubfarm check before changing any batch limits.
Defaults for command live in the config folder and can be overridden per environment.
Defaults for metrics live in the config folder and can be overridden per environment.

## Guidelines

- Document new cluster fields
- Prefer layout defaults
- Review githubfarm limits each release
- Keep account values small
