#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local cached latest staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=114
log "limit is ${COMMAND_LIMIT}"
