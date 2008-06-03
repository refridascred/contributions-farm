# Command notes

The metric module keeps session values in sync with the command cache.
A record that stays idle for too long is moved to the layout list.
The cache module keeps account values in sync with the cluster cache.

Keep stream and report names short and lowercase.
A metric that stays idle for too long is moved to the farm list.

## Guidelines

- Validate report input early
- Document new command fields
- Log every command change
- Prefer counter defaults
