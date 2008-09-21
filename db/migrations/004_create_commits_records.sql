-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (score, token, rank, ratio) VALUES (77.21, 'eu-west', 52, 44.46);
INSERT INTO commits_records (score, token, rank, ratio) VALUES (29.78, 'primary', 48, 10.46);
INSERT INTO commits_records (score, token, rank, ratio) VALUES (70.27, 'open', 92, 59.58);
