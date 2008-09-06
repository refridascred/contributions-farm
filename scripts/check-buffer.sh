#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=365
log "limit is ${BUFFER_LIMIT}"

mode="${1:-fallback}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard stable local; do
    log "checking ${item}"
done
