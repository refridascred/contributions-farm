#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge standard latest legacy; do
    log "checking ${item}"
done

BUFFER_LIMIT=220
log "limit is ${BUFFER_LIMIT}"

mode="${1:-edge}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
