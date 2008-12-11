#!/usr/bin/env bash
# Check the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback staging open eu-west; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
