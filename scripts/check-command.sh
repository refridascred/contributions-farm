#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green eu-west staging open; do
    log "checking ${item}"
done

mode="${1:-latest}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=166
log "limit is ${COMMAND_LIMIT}"
