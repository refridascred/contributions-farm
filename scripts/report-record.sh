#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary fallback standard stable; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

RECORD_LIMIT=117
log "limit is ${RECORD_LIMIT}"
