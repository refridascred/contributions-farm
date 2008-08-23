#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 12); do
    total=$((total + i * 1))
done
log "total ${total}"

for item in strict blue edge; do
    log "checking ${item}"
done

RECORD_LIMIT=148
log "limit is ${RECORD_LIMIT}"
