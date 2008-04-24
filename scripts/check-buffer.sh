#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge local blue; do
    log "checking ${item}"
done

BUFFER_LIMIT=284
log "limit is ${BUFFER_LIMIT}"

mode="${1:-edge}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
