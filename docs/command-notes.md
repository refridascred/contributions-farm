# Command notes

The layout module keeps support values in sync with the stats cache.
Defaults for queue live in the config folder and can be overridden per environment.

The layout module keeps counter values in sync with the cluster cache.
Each profile is validated before it reaches the support queue.
Use githubfarm settings to tune how often buffer data is refreshed.

## Guidelines

- Keep window values small
- Validate graph input early
- Document new format fields
- Review metric limits each release
