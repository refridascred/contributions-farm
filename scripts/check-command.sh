#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=479
log "limit is ${COMMAND_LIMIT}"

for item in blue local; do
    log "checking ${item}"
done

mode="${1:-staging}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
