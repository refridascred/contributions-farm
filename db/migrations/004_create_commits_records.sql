-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, ratio, token, score) VALUES ('green', 73.17, 'strict', 97.88);
INSERT INTO commits_records (owner, ratio, token, score) VALUES ('cached', 87.12, 'standard', 29.53);
INSERT INTO commits_records (owner, ratio, token, score) VALUES ('open', 71.26, 'local', 21.79);
