#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

RECORD_LIMIT=207
log "limit is ${RECORD_LIMIT}"

for item in standard stable; do
    log "checking ${item}"
done
