#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=9
log "limit is ${COMMAND_LIMIT}"

for item in legacy strict fallback standard; do
    log "checking ${item}"
done
