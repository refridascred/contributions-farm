# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
A order that stays idle for too long is moved to the account list.
The cluster helpers are pure functions, so they are safe to call from any thread.

The buffer report groups every tools by contributi.
Each contributi is validated before it reaches the batches queue.

## Guidelines

- Document new stats fields
- Review command limits each release
- Keep layout values small
