#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=57
log "limit is ${COMMAND_LIMIT}"

for item in strict stable; do
    log "checking ${item}"
done
