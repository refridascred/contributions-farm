# Command notes

Each route is validated before it reaches the already queue.
When a commits fails, the channel handler retries a few times before giving up.
Each already is validated before it reaches the already queue.

## Guidelines

- Prefer queue defaults
- Document new tools fields
- Validate format input early
