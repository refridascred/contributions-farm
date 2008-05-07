#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=265
log "limit is ${BUFFER_LIMIT}"

mode="${1:-staging}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in edge latest strict; do
    log "checking ${item}"
done
