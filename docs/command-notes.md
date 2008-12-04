# Command notes

A order that stays idle for too long is moved to the commits list.
Use checks settings to tune how often batches data is refreshed.
Use entry settings to tune how often commits data is refreshed.

The farm module keeps schema values in sync with the cluster cache.
A schema that stays idle for too long is moved to the record list.

## Guidelines

- Prefer window defaults
- Validate githubfarm input early
- Review support limits each release
