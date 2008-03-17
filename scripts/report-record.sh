#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy staging; do
    log "checking ${item}"
done

RECORD_LIMIT=101
log "limit is ${RECORD_LIMIT}"

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
