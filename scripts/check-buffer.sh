#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open eu-west fallback; do
    log "checking ${item}"
done

BUFFER_LIMIT=85
log "limit is ${BUFFER_LIMIT}"
