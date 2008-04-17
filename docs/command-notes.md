# Command notes

Run the graph check before changing any metrics limits.
Use session settings to tune how often order data is refreshed.
Each graph is validated before it reaches the metrics queue.

The window helpers are pure functions, so they are safe to call from any thread.
Defaults for githubfarm live in the config folder and can be overridden per environment.

## Guidelines

- Log every format change
- Validate batches input early
- Keep session values small
