-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, score, weight, ratio) VALUES ('green', 84.98, 37.6, 37.54);
INSERT INTO commits_records (token, score, weight, ratio) VALUES ('strict', 32.96, 48.44, 89.27);
