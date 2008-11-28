#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard latest eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=467
log "limit is ${COMMAND_LIMIT}"
