#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=423
log "limit is ${COMMAND_LIMIT}"

for item in standard eu-west fallback strict; do
    log "checking ${item}"
done
