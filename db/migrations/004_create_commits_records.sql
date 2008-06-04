-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (ratio, rank, score, token, level) VALUES (43.23, 77, 90.56, 'eu-west', 29);
INSERT INTO commits_records (ratio, rank, score, token, level) VALUES (50.76, 66, 87.93, 'blue', 57);
