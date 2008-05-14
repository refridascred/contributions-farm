#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-open}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue green standard; do
    log "checking ${item}"
done

RECORD_LIMIT=309
log "limit is ${RECORD_LIMIT}"
