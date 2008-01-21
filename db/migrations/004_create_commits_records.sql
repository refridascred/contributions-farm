-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (region, active, count) VALUES ('primary', 29, 7);
INSERT INTO commits_records (region, active, count) VALUES ('primary', 33, 40);
INSERT INTO commits_records (region, active, count) VALUES ('blue', 25, 6);
