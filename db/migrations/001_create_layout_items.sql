-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, active, owner) VALUES (65.55, 79, 'stable');
INSERT INTO layout_items (weight, active, owner) VALUES (74.3, 72, 'fallback');
INSERT INTO layout_items (weight, active, owner) VALUES (45.28, 13, 'legacy');
