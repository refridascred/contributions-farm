#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west staging open; do
    log "checking ${item}"
done

BUFFER_LIMIT=163
log "limit is ${BUFFER_LIMIT}"
