-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (rank, token, weight, score) VALUES (6, 'edge', 91.06, 55.56);
INSERT INTO layout_items (rank, token, weight, score) VALUES (65, 'blue', 62.39, 39.28);
INSERT INTO layout_items (rank, token, weight, score) VALUES (92, 'fallback', 29.18, 67.56);
