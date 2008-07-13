# Command notes

The order helpers are pure functions, so they are safe to call from any thread.
Keep graph and stream names short and lowercase.
The metrics module keeps window values in sync with the already cache.

## Guidelines

- Log every window change
- Review farm limits each release
- Document new order fields
- Validate metric input early
