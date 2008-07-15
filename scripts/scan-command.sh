#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy local open; do
    log "checking ${item}"
done

COMMAND_LIMIT=264
log "limit is ${COMMAND_LIMIT}"
