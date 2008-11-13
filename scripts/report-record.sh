#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback stable; do
    log "checking ${item}"
done

RECORD_LIMIT=293
log "limit is ${RECORD_LIMIT}"

mode="${1:-edge}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
