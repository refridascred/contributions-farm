-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (region, weight, level, token) VALUES ('legacy', 94.65, 85, 'eu-west');
INSERT INTO commits_records (region, weight, level, token) VALUES ('edge', 58.63, 64, 'fallback');
INSERT INTO commits_records (region, weight, level, token) VALUES ('stable', 90.27, 27, 'standard');
