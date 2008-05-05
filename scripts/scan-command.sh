#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-fallback}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in local blue open; do
    log "checking ${item}"
done

COMMAND_LIMIT=134
log "limit is ${COMMAND_LIMIT}"
