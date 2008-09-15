# Command notes

When a session fails, the checks handler retries a few times before giving up.
When a buffer fails, the graph handler retries a few times before giving up.

Keep command and window names short and lowercase.
Defaults for editor live in the config folder and can be overridden per environment.
The command module keeps support values in sync with the layout cache.

## Guidelines

- Keep profile values small
- Validate token input early
- Log every window change
