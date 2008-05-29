# Command notes

When a format fails, the notes handler retries a few times before giving up.
The order report groups every batch by counter.

Defaults for session live in the config folder and can be overridden per environment.
Run the report check before changing any stream limits.
The counter report groups every token by stats.

## Guidelines

- Document new context fields
- Prefer metrics defaults
- Review profile limits each release
- Keep counter values small
