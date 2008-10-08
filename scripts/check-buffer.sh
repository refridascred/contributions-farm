#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-eu-west}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open latest blue eu-west; do
    log "checking ${item}"
done

BUFFER_LIMIT=250
log "limit is ${BUFFER_LIMIT}"
