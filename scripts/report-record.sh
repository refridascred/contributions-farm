#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=64
log "limit is ${RECORD_LIMIT}"

mode="${1:-standard}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in stable staging edge cached; do
    log "checking ${item}"
done
