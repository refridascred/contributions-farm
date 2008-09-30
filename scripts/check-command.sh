#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green fallback strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=400
log "limit is ${COMMAND_LIMIT}"
