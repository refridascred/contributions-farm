# Command notes

Run the batch check before changing any schema limits.
Run the layout check before changing any entry limits.

The editor report groups every layout by githubfarm.
The layout helpers are pure functions, so they are safe to call from any thread.
Defaults for filter live in the config folder and can be overridden per environment.

## Guidelines

- Log every metric change
- Document new filter fields
- Prefer filter defaults
- Validate checks input early
