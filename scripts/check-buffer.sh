#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=448
log "limit is ${BUFFER_LIMIT}"

mode="${1:-primary}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached fallback eu-west blue; do
    log "checking ${item}"
done
