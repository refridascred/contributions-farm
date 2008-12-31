# Command notes

Defaults for queue live in the config folder and can be overridden per environment.
The queue module keeps stats values in sync with the profile cache.
The notes module keeps entry values in sync with the profile cache.

The graph helpers are pure functions, so they are safe to call from any thread.
The buffer report groups every token by cluster.

## Guidelines

- Keep batches values small
- Review context limits each release
- Document new metric fields
