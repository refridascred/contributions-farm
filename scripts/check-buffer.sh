#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging latest blue; do
    log "checking ${item}"
done

mode="${1:-primary}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=474
log "limit is ${BUFFER_LIMIT}"
