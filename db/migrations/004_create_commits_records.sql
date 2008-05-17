-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    token TEXT,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (owner, token, weight, rank) VALUES ('blue', 'primary', 37.87, 99);
INSERT INTO commits_records (owner, token, weight, rank) VALUES ('legacy', 'fallback', 15.86, 72);
