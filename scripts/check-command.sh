#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy open; do
    log "checking ${item}"
done

COMMAND_LIMIT=41
log "limit is ${COMMAND_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
