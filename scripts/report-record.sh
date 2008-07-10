#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard latest legacy; do
    log "checking ${item}"
done

RECORD_LIMIT=112
log "limit is ${RECORD_LIMIT}"
