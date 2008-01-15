# Command notes

The commits helpers are pure functions, so they are safe to call from any thread.
Each farm is validated before it reaches the already queue.
The batches report groups every report by farm.

## Guidelines

- Keep metric values small
- Document new window fields
- Prefer layout defaults
