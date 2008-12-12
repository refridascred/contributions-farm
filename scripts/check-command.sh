#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=425
log "limit is ${COMMAND_LIMIT}"

for item in staging legacy fallback; do
    log "checking ${item}"
done
