#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-fallback}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in staging strict edge cached; do
    log "checking ${item}"
done

BUFFER_LIMIT=462
log "limit is ${BUFFER_LIMIT}"
