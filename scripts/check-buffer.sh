#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached open edge eu-west; do
    log "checking ${item}"
done

mode="${1:-fallback}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=274
log "limit is ${BUFFER_LIMIT}"
