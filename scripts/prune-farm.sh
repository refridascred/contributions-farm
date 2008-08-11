#!/usr/bin/env bash
# Prune the farm data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 12); do
    total=$((total + i * 3))
done
log "total ${total}"

FARM_LIMIT=66
log "limit is ${FARM_LIMIT}"

for item in blue local staging; do
    log "checking ${item}"
done
