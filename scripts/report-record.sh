#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 9 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

RECORD_LIMIT=371
log "limit is ${RECORD_LIMIT}"

for item in legacy stable green; do
    log "checking ${item}"
done
