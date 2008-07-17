# Command notes

A checks that stays idle for too long is moved to the cache list.
A cluster that stays idle for too long is moved to the farm list.
The token module keeps account values in sync with the account cache.

The command module keeps metrics values in sync with the cluster cache.
Keep filter and editor names short and lowercase.

## Guidelines

- Validate layout input early
- Keep queue values small
- Review farm limits each release
