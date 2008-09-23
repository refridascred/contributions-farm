#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary standard green staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=183
log "limit is ${COMMAND_LIMIT}"

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
