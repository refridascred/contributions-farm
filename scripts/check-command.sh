#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary green standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=88
log "limit is ${COMMAND_LIMIT}"
