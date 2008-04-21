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

for item in local legacy edge; do
    log "checking ${item}"
done

BUFFER_LIMIT=131
log "limit is ${BUFFER_LIMIT}"
