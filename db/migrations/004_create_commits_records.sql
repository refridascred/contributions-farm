-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, score, region, rank) VALUES ('primary', 72.31, 'latest', 16);
INSERT INTO commits_records (token, score, region, rank) VALUES ('green', 70.42, 'staging', 63);
INSERT INTO commits_records (token, score, region, rank) VALUES ('local', 76.63, 'latest', 55);
