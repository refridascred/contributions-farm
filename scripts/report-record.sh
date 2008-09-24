#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=263
log "limit is ${RECORD_LIMIT}"

for item in standard local staging primary; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 3))
done
log "total ${total}"
