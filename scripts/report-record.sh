#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-staging}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in legacy primary cached staging; do
    log "checking ${item}"
done

RECORD_LIMIT=317
log "limit is ${RECORD_LIMIT}"
