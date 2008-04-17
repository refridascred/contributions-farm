#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary fallback local; do
    log "checking ${item}"
done

COMMAND_LIMIT=87
log "limit is ${COMMAND_LIMIT}"
