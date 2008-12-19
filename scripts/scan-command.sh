#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local standard stable blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=292
log "limit is ${COMMAND_LIMIT}"
