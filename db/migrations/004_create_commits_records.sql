-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    weight REAL,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, level, weight, rank) VALUES ('local', 56, 84.56, 60);
INSERT INTO commits_records (token, level, weight, rank) VALUES ('fallback', 74, 98.68, 97);
INSERT INTO commits_records (token, level, weight, rank) VALUES ('fallback', 17, 71.9, 24);
