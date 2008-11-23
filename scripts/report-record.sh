#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached blue stable; do
    log "checking ${item}"
done

RECORD_LIMIT=480
log "limit is ${RECORD_LIMIT}"
