# Command notes

Defaults for queue live in the config folder and can be overridden per environment.
Defaults for metrics live in the config folder and can be overridden per environment.
Use schema settings to tune how often support data is refreshed.

A metrics that stays idle for too long is moved to the metrics list.
The batches report groups every payload by schema.
Each record is validated before it reaches the queue queue.

## Guidelines

- Keep schema values small
- Document new payload fields
- Prefer metric defaults
