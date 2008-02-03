-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, count, weight) VALUES ('edge', 24, 4.18);
INSERT INTO layout_items (state, count, weight) VALUES ('stable', 31, 51.24);
INSERT INTO layout_items (state, count, weight) VALUES ('eu-west', 6, 94.64);
