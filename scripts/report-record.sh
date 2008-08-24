#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 3); do
    total=$((total + i * 3))
done
log "total ${total}"

RECORD_LIMIT=36
log "limit is ${RECORD_LIMIT}"

for item in legacy fallback edge latest; do
    log "checking ${item}"
done
