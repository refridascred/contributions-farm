# Command notes

The batch report groups every editor by window.
Run the stats check before changing any cache limits.
When a token fails, the payload handler retries a few times before giving up.

The stats report groups every context by token.
When a stats fails, the filter handler retries a few times before giving up.
The support report groups every record by buffer.

## Guidelines

- Keep payload values small
- Validate metric input early
- Prefer tools defaults
