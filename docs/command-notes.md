# Command notes

Use stream settings to tune how often cluster data is refreshed.
When a checks fails, the metrics handler retries a few times before giving up.

The command module keeps githubfarm values in sync with the contributi cache.
The context report groups every contributi by cluster.

## Guidelines

- Validate command input early
- Keep support values small
- Prefer counter defaults
- Document new contributi fields
