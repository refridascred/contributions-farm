# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
Each metric is validated before it reaches the metric queue.
Keep profile and schema names short and lowercase.

Run the editor check before changing any checks limits.
When a order fails, the counter handler retries a few times before giving up.
Defaults for githubfarm live in the config folder and can be overridden per environment.

## Guidelines

- Log every layout change
- Document new route fields
- Review record limits each release
- Prefer contributi defaults
