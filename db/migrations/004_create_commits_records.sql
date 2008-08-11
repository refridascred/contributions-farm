-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, score, level, ratio, label) VALUES (34, 87.28, 82, 73.63, 'latest');
INSERT INTO commits_records (rank, score, level, ratio, label) VALUES (27, 9.3, 0, 64.49, 'fallback');
INSERT INTO commits_records (rank, score, level, ratio, label) VALUES (65, 57.31, 93, 95.47, 'cached');
