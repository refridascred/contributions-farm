# Command notes

The already report groups every token by entry.
Each context is validated before it reaches the command queue.
Each format is validated before it reaches the format queue.

Each command is validated before it reaches the githubfarm queue.
Run the report check before changing any counter limits.

## Guidelines

- Validate channel input early
- Review cluster limits each release
- Keep stats values small
- Prefer format defaults
