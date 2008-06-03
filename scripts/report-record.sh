#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green edge standard fallback; do
    log "checking ${item}"
done

RECORD_LIMIT=365
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 8); do
    total=$((total + i * 4))
done
log "total ${total}"
