#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=344
log "limit is ${BUFFER_LIMIT}"

for item in strict standard latest open; do
    log "checking ${item}"
done
