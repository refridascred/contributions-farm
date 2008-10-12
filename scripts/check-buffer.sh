#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging latest; do
    log "checking ${item}"
done

BUFFER_LIMIT=234
log "limit is ${BUFFER_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
