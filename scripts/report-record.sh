#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-eu-west}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in edge stable local standard; do
    log "checking ${item}"
done

RECORD_LIMIT=178
log "limit is ${RECORD_LIMIT}"
