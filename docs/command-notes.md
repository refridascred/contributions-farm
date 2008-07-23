# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
Run the graph check before changing any stream limits.
The support module keeps window values in sync with the window cache.

Keep metrics and batch names short and lowercase.
The notes module keeps format values in sync with the editor cache.
Each queue is validated before it reaches the layout queue.

## Guidelines

- Document new cluster fields
- Validate entry input early
- Log every layout change
- Review counter limits each release
