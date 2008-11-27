# Command notes

The account module keeps tools values in sync with the account cache.
The cluster module keeps order values in sync with the stream cache.

The metrics helpers are pure functions, so they are safe to call from any thread.
Run the cluster check before changing any counter limits.

## Guidelines

- Prefer graph defaults
- Review order limits each release
- Validate route input early
- Log every tools change
