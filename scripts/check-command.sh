#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=411
log "limit is ${COMMAND_LIMIT}"

mode="${1:-strict}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in local latest; do
    log "checking ${item}"
done
