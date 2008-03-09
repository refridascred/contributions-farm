#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary green fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=299
log "limit is ${COMMAND_LIMIT}"

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
