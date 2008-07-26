-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, level, active) VALUES ('fallback', 62, 23);
INSERT INTO commits_records (region, level, active) VALUES ('staging', 38, 24);
INSERT INTO commits_records (region, level, active) VALUES ('eu-west', 12, 84);
