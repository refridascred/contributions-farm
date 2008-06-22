#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 3 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

RECORD_LIMIT=329
log "limit is ${RECORD_LIMIT}"

for item in latest cached eu-west legacy; do
    log "checking ${item}"
done
