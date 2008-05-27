#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached latest strict; do
    log "checking ${item}"
done

RECORD_LIMIT=342
log "limit is ${RECORD_LIMIT}"
