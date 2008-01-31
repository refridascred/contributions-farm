-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, owner, active, ratio) VALUES (74.93, 'cached', 98, 69.82);
INSERT INTO commits_records (weight, owner, active, ratio) VALUES (47.35, 'cached', 88, 51.93);
INSERT INTO commits_records (weight, owner, active, ratio) VALUES (15.6, 'strict', 40, 67.08);
