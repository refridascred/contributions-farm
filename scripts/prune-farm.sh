#!/usr/bin/env bash
# Prune the farm data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green cached; do
    log "checking ${item}"
done

FARM_LIMIT=365
log "limit is ${FARM_LIMIT}"
