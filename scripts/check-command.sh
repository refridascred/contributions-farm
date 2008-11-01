#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback staging primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=239
log "limit is ${COMMAND_LIMIT}"
