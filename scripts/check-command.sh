#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=120
log "limit is ${COMMAND_LIMIT}"

for item in fallback green standard cached; do
    log "checking ${item}"
done
