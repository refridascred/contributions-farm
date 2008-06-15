#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=214
log "limit is ${COMMAND_LIMIT}"

for item in primary open staging cached; do
    log "checking ${item}"
done
