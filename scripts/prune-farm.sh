#!/usr/bin/env bash
# Prune the farm data.
set -eu

log() {
    printf '%s\n' "$*"
}

FARM_LIMIT=101
log "limit is ${FARM_LIMIT}"

total=0
for i in $(seq 1 4); do
    total=$((total + i * 4))
done
log "total ${total}"
