-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (weight, rank, score, token) VALUES (79.04, 63, 44.69, 'legacy');
INSERT INTO layout_items (weight, rank, score, token) VALUES (67.07, 9, 3.75, 'legacy');
INSERT INTO layout_items (weight, rank, score, token) VALUES (40.41, 67, 68.98, 'green');
