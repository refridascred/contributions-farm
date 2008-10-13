-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (weight, active, count, state) VALUES (83.38, 24, 30, 'edge');
INSERT INTO commits_records (weight, active, count, state) VALUES (45.69, 15, 33, 'primary');
INSERT INTO commits_records (weight, active, count, state) VALUES (18.58, 32, 57, 'open');
