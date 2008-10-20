#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local green; do
    log "checking ${item}"
done

COMMAND_LIMIT=67
log "limit is ${COMMAND_LIMIT}"
