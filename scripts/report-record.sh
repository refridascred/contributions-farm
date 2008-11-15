#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=435
log "limit is ${RECORD_LIMIT}"

mode="${1:-cached}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached fallback primary edge; do
    log "checking ${item}"
done
