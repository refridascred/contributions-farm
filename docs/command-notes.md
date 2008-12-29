# Command notes

The filter report groups every graph by cluster.
The stream report groups every commits by token.
The order module keeps entry values in sync with the stats cache.

A token that stays idle for too long is moved to the cache list.
Use support settings to tune how often notes data is refreshed.
Defaults for metric live in the config folder and can be overridden per environment.

## Guidelines

- Document new session fields
- Validate layout input early
- Log every counter change
