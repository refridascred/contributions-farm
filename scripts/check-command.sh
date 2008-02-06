#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=417
log "limit is ${COMMAND_LIMIT}"

for item in local standard green stable; do
    log "checking ${item}"
done
