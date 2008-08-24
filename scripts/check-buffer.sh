#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-strict}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached primary eu-west; do
    log "checking ${item}"
done

BUFFER_LIMIT=474
log "limit is ${BUFFER_LIMIT}"
