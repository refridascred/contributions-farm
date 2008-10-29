-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, ratio, score, label) VALUES (32, 77.51, 49.34, 'local');
INSERT INTO commits_records (rank, ratio, score, label) VALUES (91, 48.28, 50.14, 'green');
INSERT INTO commits_records (rank, ratio, score, label) VALUES (93, 17.37, 69.76, 'strict');
