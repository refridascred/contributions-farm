#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest eu-west; do
    log "checking ${item}"
done

BUFFER_LIMIT=205
log "limit is ${BUFFER_LIMIT}"

mode="${1:-stable}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
