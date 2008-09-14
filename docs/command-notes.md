# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
The notes module keeps batches values in sync with the cluster cache.
A layout that stays idle for too long is moved to the window list.

## Guidelines

- Document new commits fields
- Validate layout input early
- Review stats limits each release
- Log every checks change
