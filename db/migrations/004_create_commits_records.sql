-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (label, count, ratio, score) VALUES ('strict', 70, 91.08, 84.5);
INSERT INTO commits_records (label, count, ratio, score) VALUES ('standard', 23, 74.82, 51.08);
