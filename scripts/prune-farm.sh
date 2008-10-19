#!/usr/bin/env bash
# Prune the farm data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest stable eu-west; do
    log "checking ${item}"
done

FARM_LIMIT=9
log "limit is ${FARM_LIMIT}"
