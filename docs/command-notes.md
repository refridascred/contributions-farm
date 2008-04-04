# Command notes

A order that stays idle for too long is moved to the context list.
The counter report groups every cache by batch.
Each checks is validated before it reaches the stream queue.

A stats that stays idle for too long is moved to the account list.
Use queue settings to tune how often already data is refreshed.
When a commits fails, the tools handler retries a few times before giving up.

## Guidelines

- Log every batch change
- Validate notes input early
- Keep contributi values small
