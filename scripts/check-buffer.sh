#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=459
log "limit is ${BUFFER_LIMIT}"

mode="${1:-strict}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in primary edge stable standard; do
    log "checking ${item}"
done
