#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard legacy stable strict; do
    log "checking ${item}"
done

RECORD_LIMIT=228
log "limit is ${RECORD_LIMIT}"
