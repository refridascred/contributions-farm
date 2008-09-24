# Command notes

Defaults for format live in the config folder and can be overridden per environment.
Use stream settings to tune how often context data is refreshed.
The cache module keeps notes values in sync with the farm cache.

Each farm is validated before it reaches the command queue.
The account module keeps already values in sync with the layout cache.

## Guidelines

- Review githubfarm limits each release
- Document new command fields
- Log every stream change
- Validate token input early
