#!/usr/bin/env bash
# Prune the farm data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 12); do
    total=$((total + i * 4))
done
log "total ${total}"

FARM_LIMIT=265
log "limit is ${FARM_LIMIT}"
