#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 7); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in stable fallback; do
    log "checking ${item}"
done

RECORD_LIMIT=204
log "limit is ${RECORD_LIMIT}"
