#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open legacy stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=402
log "limit is ${COMMAND_LIMIT}"
