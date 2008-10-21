#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=181
log "limit is ${RECORD_LIMIT}"

for item in cached staging open; do
    log "checking ${item}"
done

mode="${1:-blue}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
