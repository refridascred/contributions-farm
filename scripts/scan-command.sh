#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=377
log "limit is ${COMMAND_LIMIT}"

for item in fallback strict primary; do
    log "checking ${item}"
done
