#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=36
log "limit is ${RECORD_LIMIT}"

for item in strict cached fallback stable; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 9 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
