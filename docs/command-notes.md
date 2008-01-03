# Command notes

The layout report groups every notes by filter.
The counter module keeps window values in sync with the contributi cache.
The entry report groups every context by layout.

Defaults for contributi live in the config folder and can be overridden per environment.
Each queue is validated before it reaches the contributi queue.
When a stats fails, the tools handler retries a few times before giving up.

## Guidelines

- Document new already fields
- Log every batch change
- Prefer stats defaults
