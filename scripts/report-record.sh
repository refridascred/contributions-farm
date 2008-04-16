#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy strict cached fallback; do
    log "checking ${item}"
done

mode="${1:-eu-west}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

RECORD_LIMIT=420
log "limit is ${RECORD_LIMIT}"
