#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 9 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in cached eu-west primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=135
log "limit is ${COMMAND_LIMIT}"
