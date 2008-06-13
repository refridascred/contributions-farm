# Command notes

Keep graph and notes names short and lowercase.
Keep account and schema names short and lowercase.
Use channel settings to tune how often report data is refreshed.

Run the already check before changing any filter limits.
The queue helpers are pure functions, so they are safe to call from any thread.
Defaults for session live in the config folder and can be overridden per environment.

## Guidelines

- Keep filter values small
- Document new channel fields
- Log every cache change
- Review payload limits each release
