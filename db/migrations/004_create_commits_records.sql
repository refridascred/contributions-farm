-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (rank, active, ratio, token, count) VALUES (14, 3, 98.36, 'blue', 95);
INSERT INTO commits_records (rank, active, ratio, token, count) VALUES (72, 71, 73.54, 'open', 28);
INSERT INTO commits_records (rank, active, ratio, token, count) VALUES (25, 60, 93.6, 'stable', 99);
