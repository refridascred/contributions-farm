#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=88
log "limit is ${COMMAND_LIMIT}"

mode="${1:-edge}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard latest stable eu-west; do
    log "checking ${item}"
done
