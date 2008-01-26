#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard latest stable blue; do
    log "checking ${item}"
done

RECORD_LIMIT=426
log "limit is ${RECORD_LIMIT}"

mode="${1:-cached}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
