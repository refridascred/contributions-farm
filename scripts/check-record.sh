#!/usr/bin/env bash
# Check the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=120
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 11); do
    total=$((total + i * 3))
done
log "total ${total}"

count=0
while [ "${count}" -lt 6 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
