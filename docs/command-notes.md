# Command notes

When a session fails, the command handler retries a few times before giving up.
Each schema is validated before it reaches the entry queue.
The farm report groups every profile by report.

## Guidelines

- Validate metrics input early
- Prefer tools defaults
- Review stream limits each release
- Keep layout values small
