-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (level, weight, active, state, region) VALUES (95, 51.84, 67, 'staging', 'staging');
INSERT INTO commits_records (level, weight, active, state, region) VALUES (89, 15.57, 88, 'green', 'blue');
