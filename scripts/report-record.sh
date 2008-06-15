#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=439
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 12); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in strict fallback; do
    log "checking ${item}"
done
