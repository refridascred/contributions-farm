-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (ratio, level, token, weight) VALUES (93.6, 66, 'stable', 29.56);
INSERT INTO commits_records (ratio, level, token, weight) VALUES (14.22, 7, 'cached', 93.43);
