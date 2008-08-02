#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy stable strict blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=47
log "limit is ${COMMAND_LIMIT}"
