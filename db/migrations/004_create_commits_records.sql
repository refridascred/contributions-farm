-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, owner, active, weight) VALUES ('blue', 'stable', 65, 96.84);
INSERT INTO commits_records (label, owner, active, weight) VALUES ('blue', 'staging', 69, 46.71);
