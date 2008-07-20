#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard edge latest eu-west; do
    log "checking ${item}"
done

BUFFER_LIMIT=262
log "limit is ${BUFFER_LIMIT}"

mode="${1:-stable}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
