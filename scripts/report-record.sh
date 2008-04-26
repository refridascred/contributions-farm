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

RECORD_LIMIT=352
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 4); do
    total=$((total + i * 1))
done
log "total ${total}"
