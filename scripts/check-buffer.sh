#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=312
log "limit is ${BUFFER_LIMIT}"

for item in open edge legacy staging; do
    log "checking ${item}"
done

mode="${1:-primary}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
