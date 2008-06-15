#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-standard}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in legacy fallback stable latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=287
log "limit is ${COMMAND_LIMIT}"
