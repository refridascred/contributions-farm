#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy green stable eu-west; do
    log "checking ${item}"
done

mode="${1:-primary}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

RECORD_LIMIT=262
log "limit is ${RECORD_LIMIT}"
