# Command notes

The payload module keeps schema values in sync with the cluster cache.
Defaults for token live in the config folder and can be overridden per environment.
The stream report groups every batch by report.

Keep context and metrics names short and lowercase.
The stream module keeps githubfarm values in sync with the buffer cache.
Keep filter and payload names short and lowercase.

## Guidelines

- Validate batches input early
- Keep queue values small
- Prefer payload defaults
