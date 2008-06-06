#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 12); do
    total=$((total + i * 4))
done
log "total ${total}"

RECORD_LIMIT=327
log "limit is ${RECORD_LIMIT}"

for item in local cached edge; do
    log "checking ${item}"
done
