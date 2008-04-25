-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (active, rank, weight) VALUES (5, 20, 87.96);
INSERT INTO layout_items (active, rank, weight) VALUES (11, 12, 7.83);
