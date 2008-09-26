-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (token, region, ratio) VALUES ('staging', 'standard', 8.01);
INSERT INTO commits_records (token, region, ratio) VALUES ('strict', 'standard', 51.54);
