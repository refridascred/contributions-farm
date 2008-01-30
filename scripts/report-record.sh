#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in local edge stable; do
    log "checking ${item}"
done

RECORD_LIMIT=419
log "limit is ${RECORD_LIMIT}"
