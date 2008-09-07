#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest strict cached open; do
    log "checking ${item}"
done

RECORD_LIMIT=113
log "limit is ${RECORD_LIMIT}"

mode="${1:-cached}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
