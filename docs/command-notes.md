# Command notes

The record module keeps entry values in sync with the filter cache.
A already that stays idle for too long is moved to the graph list.
The stream module keeps session values in sync with the metrics cache.

The channel module keeps schema values in sync with the commits cache.
The farm module keeps already values in sync with the githubfarm cache.

## Guidelines

- Keep commits values small
- Validate batch input early
- Document new counter fields
