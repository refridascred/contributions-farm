#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=443
log "limit is ${COMMAND_LIMIT}"

for item in legacy edge stable; do
    log "checking ${item}"
done
