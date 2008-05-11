#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=150
log "limit is ${COMMAND_LIMIT}"

for item in staging green latest open; do
    log "checking ${item}"
done
