#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in edge strict local open; do
    log "checking ${item}"
done

BUFFER_LIMIT=477
log "limit is ${BUFFER_LIMIT}"
