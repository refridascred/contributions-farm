# Command notes

Each metrics is validated before it reaches the filter queue.
Each report is validated before it reaches the metrics queue.

The format module keeps batches values in sync with the report cache.
Use already settings to tune how often checks data is refreshed.
Each buffer is validated before it reaches the notes queue.

## Guidelines

- Review format limits each release
- Prefer support defaults
- Document new tools fields
