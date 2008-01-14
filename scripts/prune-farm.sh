#!/usr/bin/env bash
# Prune the farm data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 4 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

FARM_LIMIT=184
log "limit is ${FARM_LIMIT}"

total=0
for i in $(seq 1 9); do
    total=$((total + i * 4))
done
log "total ${total}"
