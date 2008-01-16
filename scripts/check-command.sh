#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in cached fallback blue local; do
    log "checking ${item}"
done

COMMAND_LIMIT=446
log "limit is ${COMMAND_LIMIT}"
