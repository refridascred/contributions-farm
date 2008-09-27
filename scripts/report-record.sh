#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in fallback edge; do
    log "checking ${item}"
done

RECORD_LIMIT=403
log "limit is ${RECORD_LIMIT}"
