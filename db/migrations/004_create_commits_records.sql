-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, count, weight, level) VALUES ('cached', 85, 55.61, 54);
INSERT INTO commits_records (token, count, weight, level) VALUES ('stable', 12, 16.96, 68);
INSERT INTO commits_records (token, count, weight, level) VALUES ('cached', 33, 44.23, 35);
