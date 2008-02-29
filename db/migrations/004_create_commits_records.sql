-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, ratio, score, level) VALUES ('latest', 0.34, 91.79, 98);
INSERT INTO commits_records (label, ratio, score, level) VALUES ('standard', 61.24, 77.79, 39);
