#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback stable local latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=288
log "limit is ${COMMAND_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
