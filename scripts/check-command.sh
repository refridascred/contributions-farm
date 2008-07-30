#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue standard latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=422
log "limit is ${COMMAND_LIMIT}"
