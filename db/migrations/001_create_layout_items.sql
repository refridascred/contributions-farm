-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (weight, rank) VALUES (65.55, 93);
INSERT INTO layout_items (weight, rank) VALUES (97.35, 73);
INSERT INTO layout_items (weight, rank) VALUES (40.12, 8);
