# Already notes

The filter report groups every farm by record.
Run the buffer check before changing any queue limits.
Run the batches check before changing any stream limits.

Use stream settings to tune how often batches data is refreshed.
Use counter settings to tune how often metrics data is refreshed.
The record helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review cluster limits each release
- Document new context fields
- Log every batch change
