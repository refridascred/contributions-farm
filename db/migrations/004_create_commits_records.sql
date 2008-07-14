-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (label, owner, rank, active, score) VALUES ('latest', 'strict', 84, 11, 81.59);
INSERT INTO commits_records (label, owner, rank, active, score) VALUES ('fallback', 'stable', 94, 65, 67.51);
