#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=490
log "limit is ${COMMAND_LIMIT}"

for item in green cached; do
    log "checking ${item}"
done
