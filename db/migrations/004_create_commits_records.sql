-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (region, active, owner) VALUES ('strict', 66, 'blue');
INSERT INTO commits_records (region, active, owner) VALUES ('green', 87, 'strict');
INSERT INTO commits_records (region, active, owner) VALUES ('stable', 93, 'blue');
