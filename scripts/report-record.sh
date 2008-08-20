#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green cached legacy; do
    log "checking ${item}"
done

mode="${1:-edge}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

RECORD_LIMIT=426
log "limit is ${RECORD_LIMIT}"
