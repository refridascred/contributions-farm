#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest open; do
    log "checking ${item}"
done

COMMAND_LIMIT=317
log "limit is ${COMMAND_LIMIT}"
