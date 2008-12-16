-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, token, ratio) VALUES ('stable', 'local', 34.56);
INSERT INTO commits_records (region, token, ratio) VALUES ('blue', 'primary', 53.8);
