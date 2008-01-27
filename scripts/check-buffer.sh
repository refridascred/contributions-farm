#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green cached standard; do
    log "checking ${item}"
done

BUFFER_LIMIT=41
log "limit is ${BUFFER_LIMIT}"
