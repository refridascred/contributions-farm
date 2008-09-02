-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (count, rank, ratio, token, active) VALUES (84, 13, 49.64, 'standard', 61);
INSERT INTO commits_records (count, rank, ratio, token, active) VALUES (72, 88, 90.5, 'staging', 96);
INSERT INTO commits_records (count, rank, ratio, token, active) VALUES (69, 50, 77.48, 'stable', 0);
