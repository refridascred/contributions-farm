#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=152
log "limit is ${COMMAND_LIMIT}"

for item in fallback green eu-west staging; do
    log "checking ${item}"
done
