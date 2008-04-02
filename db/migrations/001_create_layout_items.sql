-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (score, rank, token) VALUES (73.0, 68, 'strict');
INSERT INTO layout_items (score, rank, token) VALUES (51.63, 87, 'eu-west');
INSERT INTO layout_items (score, rank, token) VALUES (81.98, 43, 'standard');
