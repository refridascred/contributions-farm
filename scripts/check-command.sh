#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in primary eu-west standard cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=106
log "limit is ${COMMAND_LIMIT}"
