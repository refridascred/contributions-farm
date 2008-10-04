#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging open; do
    log "checking ${item}"
done

COMMAND_LIMIT=348
log "limit is ${COMMAND_LIMIT}"
