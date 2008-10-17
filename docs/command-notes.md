# Command notes

When a order fails, the metrics handler retries a few times before giving up.
A cluster that stays idle for too long is moved to the batches list.
Each tools is validated before it reaches the metric queue.

## Guidelines

- Log every metric change
- Prefer token defaults
- Validate queue input early
