#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 4))
done
log "total ${total}"

RECORD_LIMIT=310
log "limit is ${RECORD_LIMIT}"

for item in latest cached; do
    log "checking ${item}"
done
