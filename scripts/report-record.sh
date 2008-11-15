#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-staging}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west edge local staging; do
    log "checking ${item}"
done

RECORD_LIMIT=381
log "limit is ${RECORD_LIMIT}"
