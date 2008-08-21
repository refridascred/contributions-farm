#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=189
log "limit is ${COMMAND_LIMIT}"

for item in standard blue stable; do
    log "checking ${item}"
done
