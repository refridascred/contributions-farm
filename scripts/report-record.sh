#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=359
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 9); do
    total=$((total + i * 5))
done
log "total ${total}"

count=0
while [ "${count}" -lt 4 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
