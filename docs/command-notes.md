# Command notes

Each farm is validated before it reaches the channel queue.
Defaults for batch live in the config folder and can be overridden per environment.

When a cluster fails, the contributi handler retries a few times before giving up.
A contributi that stays idle for too long is moved to the stats list.
A checks that stays idle for too long is moved to the schema list.

## Guidelines

- Document new buffer fields
- Log every filter change
- Keep session values small
- Review support limits each release
