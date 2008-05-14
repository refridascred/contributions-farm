#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-primary}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open fallback; do
    log "checking ${item}"
done

RECORD_LIMIT=198
log "limit is ${RECORD_LIMIT}"
