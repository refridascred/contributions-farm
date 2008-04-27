#!/usr/bin/env bash
# Prune the farm data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging stable latest; do
    log "checking ${item}"
done

FARM_LIMIT=120
log "limit is ${FARM_LIMIT}"
