#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached legacy stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=244
log "limit is ${COMMAND_LIMIT}"
