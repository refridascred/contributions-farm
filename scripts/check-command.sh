#!/usr/bin/env bash
# Check the command data.
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

for item in primary staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=442
log "limit is ${COMMAND_LIMIT}"
