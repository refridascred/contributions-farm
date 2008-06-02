#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=416
log "limit is ${COMMAND_LIMIT}"
