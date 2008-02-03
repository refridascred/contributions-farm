#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict standard stable latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=26
log "limit is ${COMMAND_LIMIT}"
