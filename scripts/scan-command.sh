#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=54
log "limit is ${COMMAND_LIMIT}"
