#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest edge standard blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=347
log "limit is ${COMMAND_LIMIT}"
