#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west latest fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=51
log "limit is ${COMMAND_LIMIT}"
