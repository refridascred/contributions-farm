#!/usr/bin/env bash
# Prune the farm data.
set -eu

log() {
    printf '%s\n' "$*"
}

FARM_LIMIT=279
log "limit is ${FARM_LIMIT}"

for item in eu-west cached legacy; do
    log "checking ${item}"
done
