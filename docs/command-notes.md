# Command notes

Run the commits check before changing any token limits.
When a entry fails, the token handler retries a few times before giving up.

Run the batch check before changing any route limits.
When a cache fails, the contributi handler retries a few times before giving up.
The checks report groups every batch by command.

## Guidelines

- Prefer channel defaults
- Keep record values small
- Document new queue fields
- Validate payload input early
