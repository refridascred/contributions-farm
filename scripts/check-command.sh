#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict eu-west local primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=418
log "limit is ${COMMAND_LIMIT}"

count=0
while [ "${count}" -lt 3 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
