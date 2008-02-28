-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, rank, score) VALUES (29.65, 44, 50.55);
INSERT INTO layout_items (weight, rank, score) VALUES (38.72, 44, 41.77);
INSERT INTO layout_items (weight, rank, score) VALUES (41.18, 65, 74.44);
