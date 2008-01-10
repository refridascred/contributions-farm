# Command notes

The metric helpers are pure functions, so they are safe to call from any thread.
The account module keeps profile values in sync with the cluster cache.

## Guidelines

- Log every cluster change
- Keep record values small
- Review support limits each release
