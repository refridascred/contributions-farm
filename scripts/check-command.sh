#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=249
log "limit is ${COMMAND_LIMIT}"

for item in cached latest stable; do
    log "checking ${item}"
done
