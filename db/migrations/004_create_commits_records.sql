-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, ratio, label, rank) VALUES (26.99, 86.82, 'legacy', 48);
INSERT INTO commits_records (score, ratio, label, rank) VALUES (67.32, 78.59, 'blue', 37);
INSERT INTO commits_records (score, ratio, label, rank) VALUES (40.71, 45.96, 'fallback', 45);
