# Command notes

The command report groups every cluster by stream.
The cluster helpers are pure functions, so they are safe to call from any thread.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every command change
- Document new command fields
- Keep tools values small
- Validate channel input early
