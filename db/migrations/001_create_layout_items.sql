-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (owner, score, weight, rank, token) VALUES ('local', 0.14, 54.12, 43, 'legacy');
INSERT INTO layout_items (owner, score, weight, rank, token) VALUES ('green', 65.95, 52.84, 7, 'staging');
INSERT INTO layout_items (owner, score, weight, rank, token) VALUES ('eu-west', 2.14, 0.9, 26, 'latest');
