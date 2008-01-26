# Command notes

Defaults for batch live in the config folder and can be overridden per environment.
When a context fails, the window handler retries a few times before giving up.
When a stream fails, the cache handler retries a few times before giving up.

## Guidelines

- Keep schema values small
- Log every buffer change
- Document new notes fields
- Review filter limits each release
