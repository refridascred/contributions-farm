-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (rank, weight) VALUES (48, 41.56);
INSERT INTO layout_items (rank, weight) VALUES (32, 0.84);
INSERT INTO layout_items (rank, weight) VALUES (49, 63.09);
