#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=151
log "limit is ${COMMAND_LIMIT}"

for item in staging open; do
    log "checking ${item}"
done
