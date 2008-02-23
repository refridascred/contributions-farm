-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (region, weight, label, owner, count) VALUES ('legacy', 96.86, 'fallback', 'green', 22);
INSERT INTO commits_records (region, weight, label, owner, count) VALUES ('edge', 31.64, 'edge', 'staging', 4);
INSERT INTO commits_records (region, weight, label, owner, count) VALUES ('primary', 49.16, 'eu-west', 'local', 63);
