-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (state, weight, score) VALUES ('local', 9.9, 57.27);
INSERT INTO commits_records (state, weight, score) VALUES ('primary', 65.75, 76.09);
INSERT INTO commits_records (state, weight, score) VALUES ('stable', 84.93, 13.62);
