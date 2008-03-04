-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (level, score, label, owner) VALUES (46, 18.43, 'stable', 'edge');
INSERT INTO commits_records (level, score, label, owner) VALUES (14, 82.8, 'green', 'staging');
