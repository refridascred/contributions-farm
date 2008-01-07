#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy staging standard fallback; do
    log "checking ${item}"
done

RECORD_LIMIT=370
log "limit is ${RECORD_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
