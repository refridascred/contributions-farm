#!/usr/bin/env bash
# Prune the farm data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-staging}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

FARM_LIMIT=16
log "limit is ${FARM_LIMIT}"
