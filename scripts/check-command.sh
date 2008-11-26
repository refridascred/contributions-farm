#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable fallback blue staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=65
log "limit is ${COMMAND_LIMIT}"
