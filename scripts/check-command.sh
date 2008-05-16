#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=479
log "limit is ${COMMAND_LIMIT}"

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
