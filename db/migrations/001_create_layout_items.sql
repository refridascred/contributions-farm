-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, weight, ratio) VALUES ('cached', 86.31, 72.43);
INSERT INTO layout_items (state, weight, ratio) VALUES ('blue', 1.12, 79.93);
INSERT INTO layout_items (state, weight, ratio) VALUES ('edge', 97.16, 83.84);
