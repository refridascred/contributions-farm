-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (token, score, level) VALUES ('open', 62.59, 90);
INSERT INTO commits_records (token, score, level) VALUES ('cached', 25.76, 74);
INSERT INTO commits_records (token, score, level) VALUES ('blue', 12.97, 24);
