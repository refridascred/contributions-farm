#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached open legacy fallback; do
    log "checking ${item}"
done

BUFFER_LIMIT=77
log "limit is ${BUFFER_LIMIT}"
