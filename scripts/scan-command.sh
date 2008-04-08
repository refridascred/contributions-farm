#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=180
log "limit is ${COMMAND_LIMIT}"

for item in latest local stable edge; do
    log "checking ${item}"
done
