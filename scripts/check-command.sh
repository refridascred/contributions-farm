#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=174
log "limit is ${COMMAND_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in legacy fallback cached edge; do
    log "checking ${item}"
done
