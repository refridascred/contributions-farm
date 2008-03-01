-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, owner, label, rank, count) VALUES ('local', 'staging', 'legacy', 44, 17);
INSERT INTO commits_records (token, owner, label, rank, count) VALUES ('strict', 'stable', 'fallback', 11, 72);
