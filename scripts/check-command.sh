#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge stable; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 4 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

COMMAND_LIMIT=318
log "limit is ${COMMAND_LIMIT}"
