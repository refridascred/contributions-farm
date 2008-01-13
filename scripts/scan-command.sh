#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=334
log "limit is ${COMMAND_LIMIT}"

for item in latest eu-west legacy staging; do
    log "checking ${item}"
done
