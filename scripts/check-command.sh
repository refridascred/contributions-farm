#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict primary open local; do
    log "checking ${item}"
done

COMMAND_LIMIT=365
log "limit is ${COMMAND_LIMIT}"

mode="${1:-primary}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
