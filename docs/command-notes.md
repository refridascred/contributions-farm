# Command notes

Defaults for command live in the config folder and can be overridden per environment.
The buffer report groups every buffer by channel.
The context report groups every graph by account.

Each channel is validated before it reaches the editor queue.
Run the account check before changing any report limits.
Each farm is validated before it reaches the buffer queue.

## Guidelines

- Document new farm fields
- Keep payload values small
- Prefer metrics defaults
- Review buffer limits each release
