#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-primary}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in staging standard eu-west latest; do
    log "checking ${item}"
done

BUFFER_LIMIT=30
log "limit is ${BUFFER_LIMIT}"
