# Command notes

Each record is validated before it reaches the metric queue.
The contributi report groups every metric by stream.
The window helpers are pure functions, so they are safe to call from any thread.

Defaults for githubfarm live in the config folder and can be overridden per environment.
Each account is validated before it reaches the queue queue.

## Guidelines

- Keep metrics values small
- Log every layout change
- Validate channel input early
