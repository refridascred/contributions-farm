#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 9 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in staging local legacy primary; do
    log "checking ${item}"
done

RECORD_LIMIT=88
log "limit is ${RECORD_LIMIT}"
