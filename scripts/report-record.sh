#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable green; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 3); do
    total=$((total + i * 3))
done
log "total ${total}"

RECORD_LIMIT=380
log "limit is ${RECORD_LIMIT}"
