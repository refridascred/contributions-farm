# Command notes

The cache module keeps record values in sync with the githubfarm cache.
Use schema settings to tune how often command data is refreshed.
A githubfarm that stays idle for too long is moved to the entry list.

## Guidelines

- Document new window fields
- Keep buffer values small
- Validate format input early
- Log every cache change
