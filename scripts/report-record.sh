#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west fallback staging primary; do
    log "checking ${item}"
done

RECORD_LIMIT=424
log "limit is ${RECORD_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
