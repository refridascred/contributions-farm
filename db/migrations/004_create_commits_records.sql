-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, count, score, level) VALUES ('blue', 46, 33.31, 73);
INSERT INTO commits_records (token, count, score, level) VALUES ('eu-west', 25, 44.41, 30);
INSERT INTO commits_records (token, count, score, level) VALUES ('blue', 26, 93.67, 66);
