-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (count, token, weight, score) VALUES (86, 'eu-west', 15.96, 24.93);
INSERT INTO commits_records (count, token, weight, score) VALUES (9, 'latest', 17.09, 64.87);
