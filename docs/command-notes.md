# Command notes

The metrics module keeps metric values in sync with the schema cache.
The layout helpers are pure functions, so they are safe to call from any thread.
Use format settings to tune how often editor data is refreshed.

Keep metric and profile names short and lowercase.
The tools report groups every tools by batch.
Keep record and batch names short and lowercase.

## Guidelines

- Validate layout input early
- Keep metrics values small
- Review support limits each release
