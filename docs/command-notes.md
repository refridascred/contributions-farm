# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
The batches report groups every report by tools.
Run the payload check before changing any commits limits.

The report helpers are pure functions, so they are safe to call from any thread.
The batches report groups every tools by stream.
Keep payload and batches names short and lowercase.

## Guidelines

- Validate filter input early
- Review record limits each release
- Log every notes change
- Prefer account defaults
