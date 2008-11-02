#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in staging open edge; do
    log "checking ${item}"
done

RECORD_LIMIT=478
log "limit is ${RECORD_LIMIT}"
