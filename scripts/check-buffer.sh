#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy latest eu-west strict; do
    log "checking ${item}"
done

mode="${1:-standard}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=60
log "limit is ${BUFFER_LIMIT}"
