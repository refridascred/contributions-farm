#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached strict stable; do
    log "checking ${item}"
done

RECORD_LIMIT=14
log "limit is ${RECORD_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
