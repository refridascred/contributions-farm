#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=260
log "limit is ${COMMAND_LIMIT}"

for item in standard latest cached strict; do
    log "checking ${item}"
done
