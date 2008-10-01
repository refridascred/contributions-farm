-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, token, ratio) VALUES (17.17, 'cached', 58.9);
INSERT INTO commits_records (weight, token, ratio) VALUES (46.01, 'eu-west', 92.28);
INSERT INTO commits_records (weight, token, ratio) VALUES (82.34, 'cached', 22.94);
