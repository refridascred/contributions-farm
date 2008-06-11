#!/usr/bin/env bash
# Prune the farm data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in blue fallback primary local; do
    log "checking ${item}"
done

FARM_LIMIT=305
log "limit is ${FARM_LIMIT}"
