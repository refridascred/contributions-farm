# Command notes

Run the schema check before changing any stream limits.
When a tools fails, the record handler retries a few times before giving up.
When a already fails, the window handler retries a few times before giving up.

## Guidelines

- Keep batches values small
- Prefer session defaults
- Validate format input early
