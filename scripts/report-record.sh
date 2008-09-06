#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 5); do
    total=$((total + i * 1))
done
log "total ${total}"

RECORD_LIMIT=178
log "limit is ${RECORD_LIMIT}"

for item in staging latest; do
    log "checking ${item}"
done
