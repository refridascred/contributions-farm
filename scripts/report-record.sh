#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached fallback staging stable; do
    log "checking ${item}"
done

RECORD_LIMIT=169
log "limit is ${RECORD_LIMIT}"
