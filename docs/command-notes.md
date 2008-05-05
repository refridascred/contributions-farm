# Command notes

Run the command check before changing any order limits.
The layout module keeps metric values in sync with the checks cache.
When a checks fails, the contributi handler retries a few times before giving up.

Each token is validated before it reaches the profile queue.
Use account settings to tune how often support data is refreshed.
When a contributi fails, the cache handler retries a few times before giving up.

## Guidelines

- Keep context values small
- Log every entry change
- Document new metric fields
- Review window limits each release
