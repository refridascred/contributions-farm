#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable local fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=422
log "limit is ${COMMAND_LIMIT}"

mode="${1:-edge}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
