-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (score, token, rank, ratio) VALUES (98.54, 'primary', 45, 97.54);
INSERT INTO commits_records (score, token, rank, ratio) VALUES (68.59, 'green', 66, 44.89);
