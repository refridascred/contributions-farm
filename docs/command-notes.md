# Command notes

Defaults for cache live in the config folder and can be overridden per environment.
Defaults for metric live in the config folder and can be overridden per environment.
Use route settings to tune how often batch data is refreshed.

Each cache is validated before it reaches the commits queue.
Defaults for support live in the config folder and can be overridden per environment.
The channel module keeps channel values in sync with the buffer cache.

## Guidelines

- Keep channel values small
- Validate githubfarm input early
- Document new notes fields
