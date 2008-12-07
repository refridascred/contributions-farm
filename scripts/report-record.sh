#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 5))
done
log "total ${total}"

RECORD_LIMIT=129
log "limit is ${RECORD_LIMIT}"

for item in staging edge; do
    log "checking ${item}"
done
