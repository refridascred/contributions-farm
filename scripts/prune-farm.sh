#!/usr/bin/env bash
# Prune the farm data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 10); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in legacy edge local cached; do
    log "checking ${item}"
done

FARM_LIMIT=460
log "limit is ${FARM_LIMIT}"
