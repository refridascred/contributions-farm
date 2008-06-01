-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, level, label, score) VALUES ('staging', 58, 'staging', 57.75);
INSERT INTO commits_records (token, level, label, score) VALUES ('open', 35, 'primary', 47.52);
INSERT INTO commits_records (token, level, label, score) VALUES ('strict', 27, 'strict', 19.47);
