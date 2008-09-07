#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open legacy green staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=254
log "limit is ${COMMAND_LIMIT}"
