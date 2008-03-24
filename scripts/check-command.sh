#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=44
log "limit is ${COMMAND_LIMIT}"

for item in strict edge green cached; do
    log "checking ${item}"
done
