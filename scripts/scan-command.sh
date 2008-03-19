#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=64
log "limit is ${COMMAND_LIMIT}"

for item in legacy green open strict; do
    log "checking ${item}"
done
