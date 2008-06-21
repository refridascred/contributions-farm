-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (token, rank, weight, count, label) VALUES ('latest', 87, 3.68, 44, 'open');
INSERT INTO commits_records (token, rank, weight, count, label) VALUES ('edge', 43, 64.83, 35, 'open');
