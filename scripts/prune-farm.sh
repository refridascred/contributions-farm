#!/usr/bin/env bash
# Prune the farm data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict open stable; do
    log "checking ${item}"
done

FARM_LIMIT=134
log "limit is ${FARM_LIMIT}"
