-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    token TEXT,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, weight, token, region) VALUES (24, 73.16, 'standard', 'blue');
INSERT INTO commits_records (active, weight, token, region) VALUES (88, 58.05, 'fallback', 'green');
INSERT INTO commits_records (active, weight, token, region) VALUES (96, 24.69, 'cached', 'cached');
