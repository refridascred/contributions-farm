#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in stable eu-west fallback standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=463
log "limit is ${COMMAND_LIMIT}"
