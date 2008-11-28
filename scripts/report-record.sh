#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

RECORD_LIMIT=476
log "limit is ${RECORD_LIMIT}"

for item in fallback strict eu-west legacy; do
    log "checking ${item}"
done
