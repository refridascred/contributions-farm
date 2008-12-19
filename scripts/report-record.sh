#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 7 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in green eu-west open latest; do
    log "checking ${item}"
done

RECORD_LIMIT=155
log "limit is ${RECORD_LIMIT}"
