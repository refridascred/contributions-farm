#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in local strict standard; do
    log "checking ${item}"
done

BUFFER_LIMIT=327
log "limit is ${BUFFER_LIMIT}"
