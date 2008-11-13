#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green legacy local; do
    log "checking ${item}"
done

COMMAND_LIMIT=77
log "limit is ${COMMAND_LIMIT}"
