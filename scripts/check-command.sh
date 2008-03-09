#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in staging cached fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=205
log "limit is ${COMMAND_LIMIT}"
