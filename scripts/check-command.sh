#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in eu-west blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=92
log "limit is ${COMMAND_LIMIT}"
