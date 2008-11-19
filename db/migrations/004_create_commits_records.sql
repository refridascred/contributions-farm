-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (rank, token, label, owner, active) VALUES (71, 'green', 'staging', 'stable', 22);
INSERT INTO commits_records (rank, token, label, owner, active) VALUES (44, 'strict', 'stable', 'fallback', 34);
