#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy green stable cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=299
log "limit is ${COMMAND_LIMIT}"
