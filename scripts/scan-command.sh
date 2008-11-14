#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy green standard cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=360
log "limit is ${COMMAND_LIMIT}"
