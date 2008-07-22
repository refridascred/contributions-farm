#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open strict edge fallback; do
    log "checking ${item}"
done

mode="${1:-cached}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=178
log "limit is ${BUFFER_LIMIT}"
