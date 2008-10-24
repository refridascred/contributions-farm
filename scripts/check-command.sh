#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=256
log "limit is ${COMMAND_LIMIT}"

for item in edge fallback open green; do
    log "checking ${item}"
done

mode="${1:-staging}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
