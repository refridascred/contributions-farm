# Command notes

Each window is validated before it reaches the payload queue.
A batch that stays idle for too long is moved to the route list.

A tools that stays idle for too long is moved to the batch list.
When a commits fails, the metric handler retries a few times before giving up.
Run the batch check before changing any githubfarm limits.

## Guidelines

- Keep format values small
- Prefer entry defaults
- Validate context input early
