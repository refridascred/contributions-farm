-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (weight, region, token, count, rank) VALUES (12.39, 'blue', 'stable', 48, 27);
INSERT INTO commits_records (weight, region, token, count, rank) VALUES (16.06, 'blue', 'primary', 7, 71);
INSERT INTO commits_records (weight, region, token, count, rank) VALUES (39.6, 'cached', 'staging', 46, 21);
