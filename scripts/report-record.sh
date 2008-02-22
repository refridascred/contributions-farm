#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=398
log "limit is ${RECORD_LIMIT}"

mode="${1:-eu-west}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached strict edge standard; do
    log "checking ${item}"
done
