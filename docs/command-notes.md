# Command notes

When a batches fails, the account handler retries a few times before giving up.
Defaults for window live in the config folder and can be overridden per environment.

Run the queue check before changing any metrics limits.
Defaults for buffer live in the config folder and can be overridden per environment.
The payload report groups every report by batches.

## Guidelines

- Prefer layout defaults
- Log every farm change
- Keep entry values small
