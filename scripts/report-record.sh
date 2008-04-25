#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in strict fallback; do
    log "checking ${item}"
done

RECORD_LIMIT=108
log "limit is ${RECORD_LIMIT}"
