-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (region, weight, state) VALUES ('staging', 55.18, 'stable');
INSERT INTO commits_records (region, weight, state) VALUES ('primary', 19.1, 'staging');
