#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=76
log "limit is ${COMMAND_LIMIT}"

for item in local primary cached; do
    log "checking ${item}"
done
