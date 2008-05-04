#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy green; do
    log "checking ${item}"
done

COMMAND_LIMIT=194
log "limit is ${COMMAND_LIMIT}"
