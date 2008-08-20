#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

RECORD_LIMIT=370
log "limit is ${RECORD_LIMIT}"

for item in primary edge cached open; do
    log "checking ${item}"
done
