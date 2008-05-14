#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local edge latest; do
    log "checking ${item}"
done

mode="${1:-latest}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=37
log "limit is ${BUFFER_LIMIT}"
