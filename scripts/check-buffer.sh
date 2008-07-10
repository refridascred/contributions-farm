#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest standard; do
    log "checking ${item}"
done

BUFFER_LIMIT=218
log "limit is ${BUFFER_LIMIT}"

mode="${1:-latest}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
