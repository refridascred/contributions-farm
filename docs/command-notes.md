# Command notes

Run the context check before changing any route limits.
Keep editor and counter names short and lowercase.
Use tools settings to tune how often githubfarm data is refreshed.

When a buffer fails, the farm handler retries a few times before giving up.
Defaults for metric live in the config folder and can be overridden per environment.

## Guidelines

- Keep checks values small
- Prefer cache defaults
- Document new session fields
