# Command notes

Each graph is validated before it reaches the buffer queue.
The payload report groups every tools by command.
When a contributi fails, the report handler retries a few times before giving up.

Run the token check before changing any metric limits.
Run the order check before changing any layout limits.
Run the queue check before changing any buffer limits.

## Guidelines

- Validate stats input early
- Keep session values small
- Document new profile fields
