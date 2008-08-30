#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached fallback edge local; do
    log "checking ${item}"
done

COMMAND_LIMIT=337
log "limit is ${COMMAND_LIMIT}"
