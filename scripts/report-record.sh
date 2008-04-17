#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable latest open; do
    log "checking ${item}"
done

RECORD_LIMIT=194
log "limit is ${RECORD_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
