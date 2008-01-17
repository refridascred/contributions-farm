#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west open stable latest; do
    log "checking ${item}"
done

BUFFER_LIMIT=303
log "limit is ${BUFFER_LIMIT}"
