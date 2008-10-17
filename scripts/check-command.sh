#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=204
log "limit is ${COMMAND_LIMIT}"

for item in staging primary fallback; do
    log "checking ${item}"
done
