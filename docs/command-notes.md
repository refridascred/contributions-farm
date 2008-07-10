# Command notes

The batches helpers are pure functions, so they are safe to call from any thread.
The counter module keeps stream values in sync with the tools cache.
Keep batch and route names short and lowercase.

Use context settings to tune how often graph data is refreshed.
Run the checks check before changing any stream limits.
Use command settings to tune how often report data is refreshed.

## Guidelines

- Prefer already defaults
- Keep cluster values small
- Document new checks fields
- Log every editor change
