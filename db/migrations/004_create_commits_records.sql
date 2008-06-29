-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, label, token) VALUES (40.98, 'legacy', 'open');
INSERT INTO commits_records (score, label, token) VALUES (27.73, 'stable', 'strict');
