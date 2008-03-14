#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=419
log "limit is ${COMMAND_LIMIT}"

for item in standard staging open; do
    log "checking ${item}"
done
