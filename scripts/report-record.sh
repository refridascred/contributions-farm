#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in latest primary legacy green; do
    log "checking ${item}"
done

RECORD_LIMIT=35
log "limit is ${RECORD_LIMIT}"
