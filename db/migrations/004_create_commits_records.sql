-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (region, ratio, owner) VALUES ('primary', 57.46, 'fallback');
INSERT INTO commits_records (region, ratio, owner) VALUES ('legacy', 85.16, 'legacy');
INSERT INTO commits_records (region, ratio, owner) VALUES ('strict', 72.57, 'eu-west');
