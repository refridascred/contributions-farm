#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=300
log "limit is ${COMMAND_LIMIT}"

for item in legacy green local; do
    log "checking ${item}"
done
