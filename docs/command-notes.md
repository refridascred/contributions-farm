# Command notes

Run the already check before changing any profile limits.
Run the githubfarm check before changing any counter limits.
A metric that stays idle for too long is moved to the metric list.

Defaults for batches live in the config folder and can be overridden per environment.
When a order fails, the commits handler retries a few times before giving up.
Each format is validated before it reaches the metrics queue.

## Guidelines

- Review metric limits each release
- Validate commits input early
- Log every record change
- Document new stats fields
