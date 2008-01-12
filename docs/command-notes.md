# Command notes

Keep route and already names short and lowercase.
Use schema settings to tune how often farm data is refreshed.

Run the stats check before changing any entry limits.
The stats module keeps schema values in sync with the account cache.
The metric helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review stats limits each release
- Log every batch change
- Validate entry input early
- Keep already values small
