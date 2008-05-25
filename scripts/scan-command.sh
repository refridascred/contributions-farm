#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-open}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in local strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=402
log "limit is ${COMMAND_LIMIT}"
