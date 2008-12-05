#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=55
log "limit is ${COMMAND_LIMIT}"

for item in latest fallback standard edge; do
    log "checking ${item}"
done
