-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (owner, weight, region) VALUES ('standard', 25.3, 'local');
INSERT INTO commits_records (owner, weight, region) VALUES ('cached', 24.52, 'eu-west');
INSERT INTO commits_records (owner, weight, region) VALUES ('staging', 43.51, 'standard');
