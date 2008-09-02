#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy green standard stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=371
log "limit is ${COMMAND_LIMIT}"
