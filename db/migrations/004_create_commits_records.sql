-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    rank INTEGER,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (token, weight, rank, ratio) VALUES ('stable', 59.66, 27, 69.88);
INSERT INTO commits_records (token, weight, rank, ratio) VALUES ('strict', 35.51, 12, 49.35);
