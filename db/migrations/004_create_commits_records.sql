-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, label, weight, state, token) VALUES (71, 'green', 77.58, 'green', 'green');
INSERT INTO commits_records (level, label, weight, state, token) VALUES (48, 'green', 55.77, 'local', 'latest');
