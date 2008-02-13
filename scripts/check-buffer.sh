#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback latest primary; do
    log "checking ${item}"
done

mode="${1:-staging}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=127
log "limit is ${BUFFER_LIMIT}"
