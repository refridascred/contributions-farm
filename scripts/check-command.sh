#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-staging}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue fallback stable eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=188
log "limit is ${COMMAND_LIMIT}"
