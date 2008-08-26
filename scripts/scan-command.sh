#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in latest eu-west standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=319
log "limit is ${COMMAND_LIMIT}"
