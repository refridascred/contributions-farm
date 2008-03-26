-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, token, weight, count, rank) VALUES (48.08, 'latest', 60.01, 24, 6);
INSERT INTO commits_records (ratio, token, weight, count, rank) VALUES (20.64, 'cached', 95.08, 57, 0);
INSERT INTO commits_records (ratio, token, weight, count, rank) VALUES (40.34, 'green', 72.38, 13, 3);
