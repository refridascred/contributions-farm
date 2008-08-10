# Command notes

When a graph fails, the token handler retries a few times before giving up.
The checks report groups every batch by farm.
Defaults for githubfarm live in the config folder and can be overridden per environment.

A cluster that stays idle for too long is moved to the channel list.
Use metrics settings to tune how often channel data is refreshed.

## Guidelines

- Log every checks change
- Document new stream fields
- Keep batches values small
