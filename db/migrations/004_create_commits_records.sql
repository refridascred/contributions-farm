-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (weight, token, count, rank) VALUES (49.41, 'blue', 71, 73);
INSERT INTO commits_records (weight, token, count, rank) VALUES (66.48, 'green', 34, 22);
INSERT INTO commits_records (weight, token, count, rank) VALUES (50.65, 'edge', 3, 15);
