#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=382
log "limit is ${COMMAND_LIMIT}"

for item in primary fallback eu-west legacy; do
    log "checking ${item}"
done
