-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, rank) VALUES (33.34, 77);
INSERT INTO layout_items (weight, rank) VALUES (64.91, 39);
