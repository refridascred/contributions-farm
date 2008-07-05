#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging primary blue local; do
    log "checking ${item}"
done

RECORD_LIMIT=351
log "limit is ${RECORD_LIMIT}"

mode="${1:-standard}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
