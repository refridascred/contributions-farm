#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=131
log "limit is ${COMMAND_LIMIT}"

for item in primary stable; do
    log "checking ${item}"
done
