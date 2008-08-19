-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (ratio, label, rank) VALUES (4.11, 'fallback', 55);
INSERT INTO commits_records (ratio, label, rank) VALUES (34.04, 'stable', 36);
INSERT INTO commits_records (ratio, label, rank) VALUES (73.13, 'standard', 45);
