# Command notes

The context module keeps account values in sync with the payload cache.
Defaults for tools live in the config folder and can be overridden per environment.

The batch report groups every filter by queue.
When a window fails, the order handler retries a few times before giving up.

## Guidelines

- Document new checks fields
- Review context limits each release
- Log every payload change
