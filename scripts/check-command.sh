#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=339
log "limit is ${COMMAND_LIMIT}"

for item in primary green local latest; do
    log "checking ${item}"
done
