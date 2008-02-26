#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green edge latest cached; do
    log "checking ${item}"
done

RECORD_LIMIT=59
log "limit is ${RECORD_LIMIT}"

total=0
for i in $(seq 1 4); do
    total=$((total + i * 3))
done
log "total ${total}"
