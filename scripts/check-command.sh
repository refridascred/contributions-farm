#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=131
log "limit is ${COMMAND_LIMIT}"

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
