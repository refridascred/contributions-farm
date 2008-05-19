#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=272
log "limit is ${BUFFER_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached green blue standard; do
    log "checking ${item}"
done
