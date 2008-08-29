-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (active, score, label, ratio, owner) VALUES (16, 92.63, 'edge', 73.38, 'legacy');
INSERT INTO commits_records (active, score, label, ratio, owner) VALUES (62, 70.97, 'legacy', 25.37, 'cached');
INSERT INTO commits_records (active, score, label, ratio, owner) VALUES (63, 86.21, 'primary', 15.16, 'fallback');
