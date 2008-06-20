#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict legacy green stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=451
log "limit is ${COMMAND_LIMIT}"
