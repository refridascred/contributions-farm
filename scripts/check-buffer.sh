#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west cached staging; do
    log "checking ${item}"
done

BUFFER_LIMIT=363
log "limit is ${BUFFER_LIMIT}"
