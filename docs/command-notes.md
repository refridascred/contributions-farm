# Command notes

Use token settings to tune how often batches data is refreshed.
Keep schema and context names short and lowercase.
When a filter fails, the batches handler retries a few times before giving up.

When a tools fails, the layout handler retries a few times before giving up.
Each report is validated before it reaches the schema queue.
The format module keeps route values in sync with the checks cache.

## Guidelines

- Validate already input early
- Prefer notes defaults
- Keep support values small
- Document new editor fields
