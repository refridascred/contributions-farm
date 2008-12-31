-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (weight, token, count, level) VALUES (55.6, 'eu-west', 34, 27);
INSERT INTO commits_records (weight, token, count, level) VALUES (46.9, 'local', 58, 64);
INSERT INTO commits_records (weight, token, count, level) VALUES (19.8, 'edge', 99, 58);
