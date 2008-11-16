#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

RECORD_LIMIT=406
log "limit is ${RECORD_LIMIT}"

for item in primary edge staging eu-west; do
    log "checking ${item}"
done
