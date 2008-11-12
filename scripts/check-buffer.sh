#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=245
log "limit is ${BUFFER_LIMIT}"

for item in fallback latest cached local; do
    log "checking ${item}"
done

mode="${1:-latest}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
