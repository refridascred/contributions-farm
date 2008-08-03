-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (weight, token, level) VALUES (46.44, 'eu-west', 86);
INSERT INTO commits_records (weight, token, level) VALUES (43.31, 'strict', 72);
