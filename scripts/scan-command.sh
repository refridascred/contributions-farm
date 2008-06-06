#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=265
log "limit is ${COMMAND_LIMIT}"

for item in local cached stable; do
    log "checking ${item}"
done
