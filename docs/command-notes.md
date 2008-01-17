# Command notes

Each checks is validated before it reaches the layout queue.
The graph module keeps stream values in sync with the commits cache.

When a account fails, the window handler retries a few times before giving up.
The buffer module keeps cluster values in sync with the stream cache.

## Guidelines

- Document new checks fields
- Prefer channel defaults
- Keep contributi values small
- Validate format input early
