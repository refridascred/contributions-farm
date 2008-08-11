-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (token, level, active, weight) VALUES ('fallback', 71, 58, 21.93);
INSERT INTO commits_records (token, level, active, weight) VALUES ('latest', 55, 67, 30.7);
INSERT INTO commits_records (token, level, active, weight) VALUES ('blue', 73, 17, 64.23);
