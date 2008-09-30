-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (level, score, rank, label, owner) VALUES (92, 21.12, 2, 'open', 'blue');
INSERT INTO commits_records (level, score, rank, label, owner) VALUES (2, 74.59, 89, 'latest', 'local');
