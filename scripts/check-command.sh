#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy stable fallback blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=384
log "limit is ${COMMAND_LIMIT}"
