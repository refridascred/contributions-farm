# Command notes

Run the support check before changing any filter limits.
The metric helpers are pure functions, so they are safe to call from any thread.

Run the counter check before changing any command limits.
The window report groups every graph by editor.

## Guidelines

- Document new command fields
- Log every account change
- Review channel limits each release
