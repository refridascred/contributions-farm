# Command notes

When a context fails, the notes handler retries a few times before giving up.
Each entry is validated before it reaches the cluster queue.

## Guidelines

- Prefer order defaults
- Document new profile fields
- Keep token values small
- Validate metric input early
