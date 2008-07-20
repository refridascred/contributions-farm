#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in cached open staging eu-west; do
    log "checking ${item}"
done

RECORD_LIMIT=431
log "limit is ${RECORD_LIMIT}"
