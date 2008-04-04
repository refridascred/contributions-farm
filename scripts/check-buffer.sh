#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue open edge; do
    log "checking ${item}"
done

BUFFER_LIMIT=186
log "limit is ${BUFFER_LIMIT}"
