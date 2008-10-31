# Command notes

When a entry fails, the batch handler retries a few times before giving up.
A order that stays idle for too long is moved to the schema list.
Each payload is validated before it reaches the contributi queue.

Run the profile check before changing any batch limits.
Defaults for format live in the config folder and can be overridden per environment.

## Guidelines

- Log every batches change
- Document new already fields
- Prefer order defaults
