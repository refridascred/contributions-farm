#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green legacy local; do
    log "checking ${item}"
done

COMMAND_LIMIT=368
log "limit is ${COMMAND_LIMIT}"
