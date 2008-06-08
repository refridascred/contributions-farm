#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-strict}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in stable legacy; do
    log "checking ${item}"
done

BUFFER_LIMIT=323
log "limit is ${BUFFER_LIMIT}"
