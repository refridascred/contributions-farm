#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=95
log "limit is ${COMMAND_LIMIT}"

mode="${1:-latest}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue green local; do
    log "checking ${item}"
done
