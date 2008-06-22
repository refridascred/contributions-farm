#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=85
log "limit is ${RECORD_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in fallback blue strict; do
    log "checking ${item}"
done
