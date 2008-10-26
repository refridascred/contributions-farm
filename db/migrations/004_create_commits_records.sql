-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (level, ratio, count, token, rank) VALUES (23, 59.88, 89, 'local', 85);
INSERT INTO commits_records (level, ratio, count, token, rank) VALUES (81, 35.48, 39, 'blue', 50);
INSERT INTO commits_records (level, ratio, count, token, rank) VALUES (17, 74.55, 27, 'eu-west', 60);
