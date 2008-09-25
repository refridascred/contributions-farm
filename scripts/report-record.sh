#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green cached fallback stable; do
    log "checking ${item}"
done

RECORD_LIMIT=475
log "limit is ${RECORD_LIMIT}"
