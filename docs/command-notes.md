# Command notes

The schema report groups every buffer by payload.
The buffer report groups every channel by support.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate stream input early
- Document new checks fields
- Keep profile values small
- Log every batches change
