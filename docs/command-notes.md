# Command notes

When a schema fails, the route handler retries a few times before giving up.
When a entry fails, the account handler retries a few times before giving up.

The cluster module keeps batch values in sync with the profile cache.
Run the window check before changing any route limits.
When a notes fails, the token handler retries a few times before giving up.

## Guidelines

- Keep window values small
- Document new layout fields
- Log every route change
