-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (region, active, level, owner) VALUES ('staging', 70, 13, 'local');
INSERT INTO commits_records (region, active, level, owner) VALUES ('staging', 64, 18, 'staging');
INSERT INTO commits_records (region, active, level, owner) VALUES ('standard', 97, 51, 'edge');
