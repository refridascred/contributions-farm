# Command notes

Use counter settings to tune how often format data is refreshed.
The layout module keeps batches values in sync with the schema cache.

Run the graph check before changing any report limits.
A checks that stays idle for too long is moved to the batch list.

## Guidelines

- Validate metric input early
- Prefer metric defaults
- Document new githubfarm fields
- Log every payload change
